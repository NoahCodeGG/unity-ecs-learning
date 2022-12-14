using Other;
using UnityEngine;
namespace Managers
{
    /// <summary>
    ///     entity 工具
    /// </summary>
    public static class EntityUtil
    {
        /// <summary>
        ///     创建 Player Entity
        /// </summary>
        /// <param name="contexts">上下文</param>
        /// <param name="position">位置</param>
        /// <param name="velocity">速度</param>
        /// <param name="angel">旋转角度</param>
        /// <returns>Player GameEntity</returns>
        public static GameEntity CreatePlayerEntity(
            Contexts contexts,
            Vector2 position,
            Vector2 velocity,
            float angel = 0f
        )
        {
            var playerEntity = contexts.game.CreateEntity();
            playerEntity.isComponentsTagsPlayer = true;
            playerEntity.isComponentsTagsPhysicsTag = true;
            playerEntity.AddComponentsPosition(position);
            playerEntity.AddComponentsVelocity(velocity);
            playerEntity.AddComponentsRotation(angel);
            playerEntity.AddComponentsCmdCreateGameObject(ActorTag.Player);
            playerEntity.AddComponentsTimer(0f);
            return playerEntity;
        }

        /// <summary>
        ///     创建 子弹 Entity
        /// </summary>
        /// <param name="contexts">上下文</param>
        /// <param name="position">位置</param>
        /// <param name="velocity">速度</param>
        /// <param name="angel">旋转角度</param>
        /// <returns>子弹 GameEntity</returns>
        public static GameEntity CreateBulletEntity(
            Contexts contexts,
            Vector2 position,
            Vector2 velocity,
            float angel = 0f
        )
        {
            var bulletEntity = contexts.game.CreateEntity();
            bulletEntity.isComponentsTagsBullet = true;
            bulletEntity.isComponentsTagsPhysicsTag = true;
            bulletEntity.AddComponentsPosition(position);
            bulletEntity.AddComponentsVelocity(velocity);
            bulletEntity.AddComponentsRotation(angel);
            bulletEntity.AddComponentsCmdCreateGameObject(ActorTag.Bullet);
            return bulletEntity;
        }

        /// <summary>
        ///     创建 Enemy Entity
        /// </summary>
        /// <param name="contexts">上下文</param>
        /// <param name="position">位置</param>
        /// <param name="velocity">速度</param>
        /// <param name="angel">旋转角度</param>
        /// <returns>Player GameEntity</returns>
        public static GameEntity CreateEnemyEntity(
            Contexts contexts,
            Vector2 position,
            Vector2 velocity,
            float angel = 0f
        )
        {
            var enemyEntity = contexts.game.CreateEntity();
            enemyEntity.isComponentsTagsEnemy = true;
            enemyEntity.isComponentsTagsPhysicsTag = true;
            enemyEntity.AddComponentsPosition(position);
            enemyEntity.AddComponentsVelocity(velocity);
            enemyEntity.AddComponentsRotation(angel);
            enemyEntity.AddComponentsCmdCreateGameObject(ActorTag.Enemy);
            return enemyEntity;
        }
    }
}