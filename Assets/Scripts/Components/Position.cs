using Entitas;
using UnityEngine;
namespace Components
{
    /// <summary>
    ///     位置 component
    /// </summary>
    public sealed class Position : IComponent
    {
        /// <summary>
        ///     位置
        /// </summary>
        public Vector2 Value;
    }
}