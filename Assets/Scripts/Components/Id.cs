using Entitas;
using Entitas.CodeGeneration.Attributes;
namespace Components
{
    [Game, Input]
    public class Id : IComponent
    {
        [PrimaryEntityIndex]
        public int Value;
    }
}