using UnityEngine;
namespace Hybrid
{
    /// <summary>
    ///     玩家 view
    /// </summary>
    public class PlayerView : View
    {
        /// <summary>
        ///     开火起始点
        /// </summary>
        public Transform shoot;

        protected override void OnDestroyEntityHandler()
        {
            base.OnDestroyEntityHandler();

            // 销毁
            Destroy(gameObject);
        }
    }
}