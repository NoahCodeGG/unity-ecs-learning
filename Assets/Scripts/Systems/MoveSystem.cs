using Entitas;
using UnityEngine;
namespace Systems
{
    public class MoveSystem : IExecuteSystem
    {

        private readonly IGroup<GameEntity> _group;

        public MoveSystem(Contexts contexts)
        {
            _group = contexts.game.GetGroup(GameMatcher.AllOf(
                GameMatcher.ComponentsPosition,
                GameMatcher.ComponentsVelocity,
                GameMatcher.ComponentsView
            ));
        }

        public void Execute()
        {
            foreach (var entity in _group.GetEntities()) {
                var entityComponentsPosition = entity.componentsPosition;
                var entityComponentsVelocity = entity.componentsVelocity;
                var deltaTime = Time.deltaTime;

                entity.ReplaceComponentsPosition(new Vector2(
                    entityComponentsPosition.Value.x + deltaTime*entityComponentsVelocity.Value.x,
                    entityComponentsPosition.Value.y + deltaTime*entityComponentsVelocity.Value.y
                ));

                entity.componentsView.ViewGameObject.transform.position = entity.componentsPosition.Value;
            }
        }
    }
}