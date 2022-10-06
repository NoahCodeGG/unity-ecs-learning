using Entitas;
using UnityEngine;
namespace Components
{
    /// <summary>
    ///     速度 component
    /// </summary>
    public sealed class Velocity : IComponent
    {
        /// <summary>
        ///     速度值
        /// </summary>
        public Vector2 Value;
    }
}