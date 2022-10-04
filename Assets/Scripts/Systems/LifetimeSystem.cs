using Entitas;
using UnityEngine;
namespace Systems
{
    public class LifetimeSystem : IExecuteSystem
    {

        private readonly IGroup<GameEntity> _group;

        public LifetimeSystem(Contexts contexts)
        {
            _group = contexts.game.GetGroup(GameMatcher.ComponentsLifetime);
        }

        public void Execute()
        {
            foreach (var gameEntity in _group.GetEntities()) {
                var newTime = gameEntity.componentsLifetime.Time - Time.deltaTime;
                if (newTime <= 0) gameEntity.isComponentsDestroyFlag = true;
                else gameEntity.ReplaceComponentsLifetime(newTime);
            }
        }
    }
}