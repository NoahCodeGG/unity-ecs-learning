using Entitas;
using Hybrid;
namespace Components
{
    /// <summary>
    ///     view component
    /// </summary>
    public sealed class View : IComponent
    {
        /// <summary>
        ///     关联物体
        /// </summary>
        public Hybrid.View ViewGameObject;
    }
}