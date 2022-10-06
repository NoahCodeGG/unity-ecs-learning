using Entitas.Unity;
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
        /// 物理引擎
        /// </summary>
        public Rigidbody2D Rigidbody => _rigidbody;

        protected override void OnDestroyEntityHandler()
        {
            base.OnDestroyEntityHandler();

            // 销毁
            Destroy(gameObject);
        }
        
        private void OnCollisionEnter2D(Collision2D col)
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