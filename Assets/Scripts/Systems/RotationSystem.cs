using Entitas;
using UnityEngine;
namespace Systems
{
    public class RotationSystem : IExecuteSystem
    {

        private readonly IGroup<GameEntity> _group;

        public RotationSystem(Contexts contexts)
        {
            _group = contexts.game.GetGroup(GameMatcher.AllOf(
                GameMatcher.ComponentsRotation,
                GameMatcher.ComponentsView
            ));
        }

        public void Execute()
        {
            foreach (var gameEntity in _group.GetEntities()) {
                var angel = gameEntity.componentsRotation.Angel;
                gameEntity.componentsView.ViewGameObject.transform.rotation = Quaternion.Euler(0f, 0f, angel);
            }
        }
    }
}