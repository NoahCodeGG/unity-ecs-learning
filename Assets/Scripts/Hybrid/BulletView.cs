using Managers;
namespace Hybrid
{
    /// <summary>
    ///     子弹 view
    /// </summary>
    public class BulletView : View
    {
        /// <summary>
        ///     销毁 handler
        /// </summary>
        protected override void OnDestroyEntityHandler()
        {
            // 对象池回收
            PoolManager.Instance.bulletPrefabPool.Recycle(this);
        }
    }
}