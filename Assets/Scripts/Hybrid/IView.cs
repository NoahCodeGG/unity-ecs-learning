namespace Hybrid
{
    /// <summary>
    ///     view interface
    /// </summary>
    public interface IView
    {
        /// <summary>
        ///     关联 entity
        /// </summary>
        /// <param name="contexts">上下文</param>
        /// <param name="entity">待关联 entity</param>
        void Link(Contexts contexts, GameEntity entity);
    }
}