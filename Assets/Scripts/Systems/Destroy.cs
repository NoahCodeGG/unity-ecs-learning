using Entitas;
using UnityEngine;
namespace Systems
{
    public class Destroy : ICleanupSystem
    {

        private readonly IGroup<GameEntity> _group;

        public Destroy(Contexts contexts)
        {
            _group = contexts.game.GetGroup(GameMatcher.ComponentsFlagsDestroy);
        }

        public void Cleanup()
        {
            foreach (var gameEntity in _group.GetEntities()) gameEntity.Destroy();
        }
    }
}