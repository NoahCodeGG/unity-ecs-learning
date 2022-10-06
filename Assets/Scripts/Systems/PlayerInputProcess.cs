using System.Collections.Generic;
using Entitas;
using Other;
using UnityEngine;
namespace Systems
{
    public class PlayerInputProcess : ReactiveSystem<InputEntity>
    {
        private readonly Contexts _contexts;
        private readonly Camera _mainCamera;
        private readonly IGroup<GameEntity> _playerGroup;

        public PlayerInputProcess(Contexts context) : base(context.input)
        {
            _mainCamera = Camera.main;
            _contexts = context;
            _playerGroup = _contexts.game.GetGroup(GameMatcher.ComponentsTagsPlayer);
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
                var angle = dir.Vector2D2Angle();
                playerEntity.ReplaceComponentsRotation(angle);

                // 开火
                if (inputEntity.componentsInput.Fire) playerEntity.AddComponentsCmdFire(angle);
            }
        }
    }
}