using System.Collections.Generic;
using Entitas;
using UnityEngine;
namespace Systems
{
    public class PlayerInputProcessSystem : ReactiveSystem<InputEntity>
    {
        private readonly Contexts _contexts;
        private readonly Camera _mainCamera;
        private readonly IGroup<GameEntity> _playerGroup;

        public PlayerInputProcessSystem(Contexts context) : base(context.input)
        {
            _mainCamera = Camera.main;
            _contexts = context;
            _playerGroup = _contexts.game.GetGroup(GameMatcher.ComponentsPlayerTag);
        }

        protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context)
        {
            return context.CreateCollector(InputMatcher.ComponentsInput);
        }

        protected override bool Filter(InputEntity entity)
        {
            return true;
        }

        protected override void Execute(List<InputEntity> entities)
        {
            var playerEntity = _playerGroup.GetSingleEntity();
            foreach (var inputEntity in entities) {
                // 移动
                var inputEntityComponentsInput = inputEntity.componentsInput;
                playerEntity.ReplaceComponentsVelocity(new Vector2(
                    inputEntityComponentsInput.Direction.x*10,
                    inputEntityComponentsInput.Direction.y*10
                ));

                // 旋转
                var mousePosition = inputEntityComponentsInput.MousePosition;
                var mouseWorldPosition = _mainCamera.ScreenToWorldPoint(mousePosition);
                var dir = new Vector2(mouseWorldPosition.x, mouseWorldPosition.y) - playerEntity.componentsPosition.Value;
                var angle = Vector2.SignedAngle(Vector2.up, dir);
                playerEntity.ReplaceComponentsRotation(angle);

                // 开火
                if (inputEntity.componentsInput.Fire) playerEntity.AddComponentsFireCmd(angle);
            }
        }
    }
}