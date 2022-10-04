using Systems;
namespace Managers
{
    /// <summary>
    ///     游戏 system
    /// </summary>
    public class GameSystems : Feature
    {
        public GameSystems(Contexts contexts)
        {
            // 玩家生成
            Add(new PlayerSpawnSystem(contexts));

            // 玩家输入
            Add(new InputSystem(contexts));

            // 玩家输入处理
            Add(new PlayerInputProcessSystem(contexts));

            // 移动
            Add(new MoveSystem(contexts));

            // 旋转
            Add(new RotationSystem(contexts));

            // 开火
            Add(new FireSystem(contexts));

            // 创建物体
            Add(new AddViewSystem(contexts));

            // 生命时间
            Add(new LifetimeSystem(contexts));

            // 事件
            Add(new GameEventSystems(contexts));

            // 清理
            Add(new InputCleanupSystem(contexts));

            // 物品销毁
            Add(new DestroySystem(contexts));
        }
    }
}