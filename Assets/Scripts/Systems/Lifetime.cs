using Entitas;
using UnityEngine;
namespace Systems
{
    public class Lifetime : IExecuteSystem
    {

        private readonly IGroup<GameEntity> _group;

        public Lifetime(Contexts contexts)
        {
            _group = contexts.game.GetGroup(GameMatcher.ComponentsLifetime);
        }

        public void Execute()
        {
            foreach (var gameEntity in _group.GetEntities()) {
                var newTime = gameEntity.componentsLifetime.Time - Time.deltaTime;
                if (newTime <= 0) gameEntity.isComponentsFlagsDestroy = true;
                else gameEntity.ReplaceComponentsLifetime(newTime);
            }
        }
    }
}