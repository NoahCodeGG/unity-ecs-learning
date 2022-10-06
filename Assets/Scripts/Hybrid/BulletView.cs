using System;
using Entitas.Unity;
using Managers;
using Other;
using UnityEngine;
namespace Hybrid
{
    /// <summary>
    ///     子弹 view
    /// </summary>
    public class BulletView : View,IPhysicsView
    {
        [SerializeField]private Rigidbody2D _rigidbody;
        
        /// <summary>
        /// 物理引擎
        /// </summary>
        public Rigidbody2D Rigidbody => _rigidbody;
        
        /// <summary>
        ///     销毁 handler
        /// </summary>
        protected override void OnDestroyEntityHandler()
        {
            // 对象池回收
            PoolManager.Instance.bulletPrefabPool.Recycle(this);
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            var selfEntity = SelfEntity;

            if (col.gameObject.GetEntityLink().entity is GameEntity otherEntity)
                GameManager.Contexts.physics.componentsPhysics.CollisionInfos.Add(new CollisionInfo {
                    sourceId = selfEntity.componentsId.Value,
                    otherId = otherEntity.componentsId.Value
                });
        }
    }
}