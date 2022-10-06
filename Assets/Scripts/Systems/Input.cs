using Entitas;
using UnityEngine;
namespace Systems
{
    public class Input : IExecuteSystem
    {

        private readonly Contexts _contexts;

        public Input(Contexts contexts)
        {
            _contexts = contexts;
        }

        public void Execute()
        {
            var playerInputEntity = _contexts.input.CreateEntity();
            playerInputEntity.AddComponentsInput(
                new Vector2(UnityEngine.Input.GetAxis("Horizontal"), UnityEngine.Input.GetAxis("Vertical")),
                UnityEngine.Input.GetMouseButton(0),
                UnityEngine.Input.mousePosition
            );
        }
    }
}