using Managers;
using Other;
using UnityEngine;
namespace Hybrid
{
    /// <summary>
    ///     敌人 view
    /// </summary>
    public class EnemyView : View, IPhysicsView
    {
        [SerializeField]private Rigidbody2D _rigidbody;

        /// <summary>
        ///     物理引擎
        /// </summary>
        public Rigidbody2D Rigidbody => _rigidbody;

        protected override void OnDestroyEntityHandler()
        {
            // 对象池回收
            PoolManager.Instance.Recycle(this, ActorTag.Enemy);
        }
    }
}