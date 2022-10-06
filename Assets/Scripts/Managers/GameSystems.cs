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
            Add(new PlayerSpawn(contexts));

            // 敌人生成
            Add(new EnemySpawn(contexts));

            // 玩家输入
            Add(new Input(contexts));

            // 玩家输入处理
            Add(new PlayerInputProcess(contexts));

            // 跟随目标
            Add(new FollowTarget(contexts));

            // 开火
            Add(new Fire(contexts));

            // 创建物体
            Add(new AddView(contexts));

            // 生命时间
            Add(new Lifetime(contexts));

            // 同步位置
            Add(new SyncPosition(contexts));
            
            // 物理
            Add(new Physics(contexts));
            
            // 事件
            Add(new GameEventSystems(contexts));

            // 清理
            Add(new InputCleanup(contexts));

            // 物品销毁
            Add(new Destroy(contexts));
        }
    }
}

public class FixedUpdateGameSystems : Feature
{
    public FixedUpdateGameSystems(Contexts contexts)
    {
        // 移动
        Add(new Move(contexts));

        // 旋转
        Add(new Rotation(contexts));
    }
}