using Entitas;
using Entitas.CodeGeneration.Attributes;
namespace Components
{
    /// <summary>
    ///     销毁 flag
    /// </summary>
    [Event(EventTarget.Self)]
    public sealed class DestroyFlag : IComponent
    {
    }
}