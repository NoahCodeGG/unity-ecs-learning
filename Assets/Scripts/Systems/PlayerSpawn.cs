using Entitas;
using Managers;
using UnityEngine;
namespace Systems
{
    public class PlayerSpawn : IInitializeSystem
    {
        private readonly Contexts _contexts;

        public PlayerSpawn(Contexts contexts)
        {
            _contexts = contexts;
        }

        public void Initialize()
        {
            EntityUtil.CreatePlayerEntity(_contexts, Vector2.zero, Vector2.zero);
        }
    }
}