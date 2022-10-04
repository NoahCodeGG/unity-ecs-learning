using Entitas;
using Managers;
using UnityEngine;
namespace Systems
{
    public class PlayerSpawnSystem : IInitializeSystem
    {
        private readonly Contexts _contexts;

        public PlayerSpawnSystem(Contexts contexts)
        {
            _contexts = contexts;
        }

        public void Initialize()
        {
            EntityUtil.CreatePlayerEntity(_contexts, Vector2.zero, Vector2.zero);
        }
    }
}