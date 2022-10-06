using Entitas;
using UnityEngine;
namespace Components
{
    /// <summary>
    ///     输入 component
    /// </summary>
    [Input]
    public sealed class Input : IComponent
    {
        /// <summary>
        ///     方向
        /// </summary>
        public Vector2 Direction;

        /// <summary>
        ///     是否开火
        /// </summary>
        public bool Fire;

        /// <summary>
        ///     鼠标坐标（本地）
        /// </summary>
        public Vector2 MousePosition;
    }
}