using Entitas;
using Entitas.CodeGeneration.Attributes;
namespace Components.Flags
{
    /// <summary>
    ///     销毁 flag
    /// </summary>
    [Event(EventTarget.Self)]
    public sealed class Destroy : IComponent
    {
    }
}