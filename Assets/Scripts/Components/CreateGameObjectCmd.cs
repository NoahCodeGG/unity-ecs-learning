using Entitas;
namespace Components
{
    /// <summary>
    ///     创建物体 cmd
    /// </summary>
    public sealed class CreateGameObjectCmd : IComponent
    {
        /// <summary>
        ///     物体路径（./Resources/xxx）
        /// </summary>
        public string Path;
    }
}