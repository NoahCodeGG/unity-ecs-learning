using Entitas.Unity;
using UnityEngine;
namespace Hybrid
{
    /// <summary>
    ///     IView 实现
    /// </summary>
    public class View : MonoBehaviour, IView, IComponentsDestroyFlagListener
    {
        /// <summary>
        ///     存在 destroy flag 处理
        /// </summary>
        /// <param name="entity">entity</param>
        public void OnComponentsDestroyFlag(GameEntity entity)
        {
            // 解除关联
            gameObject.Unlink();

            OnDestroyEntityHandler();
        }

        /// <summary>
        ///     关联
        /// </summary>
        /// <param name="contexts">上下文</param>
        /// <param name="entity">待关联 entity</param>
        public void Link(Contexts contexts, GameEntity entity)
        {
            // 关联
            gameObject.Link(entity);

            // 添加 destroy flag
            entity.AddComponentsDestroyFlagListener(this);

            // 更新物体位置与旋转
            transform.position = entity.componentsPosition.Value;
            transform.rotation = Quaternion.Euler(0f, 0f, entity.componentsRotation.Angel);
        }

        protected virtual void OnDestroyEntityHandler()
        {

        }
    }
}