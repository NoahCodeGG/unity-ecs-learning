using Entitas;
using Hybrid;
using UnityEngine;
namespace Systems
{
    public class Move : IExecuteSystem
    {

        private readonly IGroup<GameEntity> _group;

        public Move(Contexts contexts)
        {
            _group = contexts.game.GetGroup(GameMatcher.AllOf(
                GameMatcher.ComponentsPosition,
                GameMatcher.ComponentsTagsPhysicsTag,
                GameMatcher.ComponentsView
            ));
        }

        public void Execute()
        {
            foreach (var entity in _group.GetEntities()) {
                var entityComponentsVelocity = entity.componentsVelocity;
                var rigidbody = ((IPhysicsView)entity.componentsView.ViewGameObject).Rigidbody;

                rigidbody.velocity = entityComponentsVelocity.Value;
            }
        }
    }
}