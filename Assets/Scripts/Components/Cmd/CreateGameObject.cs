using Entitas;
using Other;
namespace Components.Cmd
{
    /// <summary>
    ///     创建物体 cmd
    /// </summary>
    public sealed class CreateGameObject : IComponent
    {
        /// <summary>
        ///     物体标签
        /// </summary>
        public ActorTag Tag;
    }
}