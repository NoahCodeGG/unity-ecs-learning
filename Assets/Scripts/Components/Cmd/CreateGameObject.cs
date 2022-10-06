using Entitas;
namespace Components.Cmd
{
    /// <summary>
    ///     创建物体 cmd
    /// </summary>
    public sealed class CreateGameObject : IComponent
    {
        /// <summary>
        ///     物体路径（./Resources/xxx）
        /// </summary>
        public string Path;
    }
}