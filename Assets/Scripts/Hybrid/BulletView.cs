using Managers;
using Other;
using UnityEngine;
namespace Hybrid
{
    /// <summary>
    ///     子弹 view
    /// </summary>
    public class BulletView : View, IPhysicsView
    {
        [SerializeField]private Rigidbody2D _rigidbody;

        /// <summary>
        ///     物理引擎
        /// </summary>
        public Rigidbody2D Rigidbody => _rigidbody;

        /// <summary>
        ///     销毁 handler
        /// </summary>
        protected override void OnDestroyEntityHandler()
        {
            // 对象池回收
            PoolManager.Instance.Recycle(this, ActorTag.Bullet);
        }
    }
}