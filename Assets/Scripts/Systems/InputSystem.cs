using Entitas;
using UnityEngine;
namespace Systems
{
    public class InputSystem : IExecuteSystem
    {

        private readonly Contexts _contexts;

        public InputSystem(Contexts contexts)
        {
            _contexts = contexts;
        }

        public void Execute()
        {
            var playerInputEntity = _contexts.input.CreateEntity();
            playerInputEntity.AddComponentsInput(
                new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")),
                Input.GetMouseButton(0),
                Input.mousePosition
            );
        }
    }
}