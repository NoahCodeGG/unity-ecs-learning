using Entitas;
using UnityEngine;
namespace Systems
{
    public class UpdateTimerSystem : IExecuteSystem
    {

        private readonly IGroup<GameEntity> _group;

        public UpdateTimerSystem(Contexts contexts)
        {
            _group = contexts.game.GetGroup(GameMatcher.ComponentsTimer);
        }

        public void Execute()
        {
            var dt = Time.deltaTime;
            foreach (var gameEntity in _group.GetEntities()) {
                var newTime = Mathf.Max(gameEntity.componentsTimer.FireTimer - dt, 0);
                gameEntity.ReplaceComponentsTimer(newTime);
            }
        }
    }
}