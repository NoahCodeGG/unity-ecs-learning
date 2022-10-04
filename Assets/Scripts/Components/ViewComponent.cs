using Entitas;
using Hybrid;
namespace Components
{
    /// <summary>
    ///     view component
    /// </summary>
    public sealed class ViewComponent : IComponent
    {
        /// <summary>
        ///     关联物体
        /// </summary>
        public View ViewGameObject;
    }
}