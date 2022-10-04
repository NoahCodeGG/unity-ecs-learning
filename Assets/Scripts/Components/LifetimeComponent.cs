using Entitas;
namespace Components
{
    /// <summary>
    ///     生命时间 component
    /// </summary>
    public sealed class LifetimeComponent : IComponent
    {
        /// <summary>
        ///     时间
        /// </summary>
        public float Time;
    }
}