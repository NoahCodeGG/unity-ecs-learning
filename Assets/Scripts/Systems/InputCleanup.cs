using Entitas;
using UnityEngine;
namespace Systems
{
    public class InputCleanup : ICleanupSystem
    {
        private readonly Contexts _contexts;
        
        public InputCleanup(Contexts contexts)
        {
            _contexts = contexts;
        }

        public void Cleanup()
        {
            _contexts.input.DestroyAllEntities();
        }
    }
}