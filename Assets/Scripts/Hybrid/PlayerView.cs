using Cinemachine;
using Entitas.Unity;
using Managers;
using Other;
using UnityEngine;
namespace Hybrid
{
    /// <summary>
    ///     玩家 view
    /// </summary>
    public class PlayerView : View, IPhysicsView
    {

        [SerializeField]private Transform _shoot;
        [SerializeField]private Rigidbody2D _rigidbody;
        
        /// <summary>
        ///     开火起始点
        /// </summary>
        public Transform Shoot => _shoot;
        
        /// <summary>
        /// 物理引擎
        /// </summary>
        public Rigidbody2D Rigidbody => _rigidbody;

        protected override void OnDestroyEntityHandler()
        {
            base.OnDestroyEntityHandler();

            var playerFollowCinemachine = FindObjectOfType<CinemachineVirtualCamera>();
            playerFollowCinemachine.Follow = null;
            
            // 销毁
            Destroy(gameObject);
        }

        protected override void OnLinkEntityHandler()
        {
            base.OnLinkEntityHandler();

            var playerFollowCinemachine = FindObjectOfType<CinemachineVirtualCamera>();
            playerFollowCinemachine.Follow = transform;
        }
    }
}