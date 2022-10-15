using System.Collections.Generic;
using Entitas;
using Hybrid;
using Managers;
using Other;
namespace Systems
{
    public class Fire : ReactiveSystem<GameEntity>
    {

        private readonly Contexts _contexts;

        public Fire(Contexts contexts) : base(contexts.game)
        {
            _contexts = contexts;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.AllOf(
                GameMatcher.ComponentsTagsPlayer,
                GameMatcher.ComponentsCmdFire,
                GameMatcher.ComponentsView
            ));
        }

        protected override bool Filter(GameEntity entity)
        {
            return true;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var gameEntity in entities) {
                var fireCmd = gameEntity.componentsCmdFire;
                gameEntity.RemoveComponentsCmdFire();

                if (gameEntity.componentsTimer.FireTimer > 0) continue;

                // TODO 设置开火间隔时间
                gameEntity.ReplaceComponentsTimer(0.5f);

                var playerView = (PlayerView)gameEntity.componentsView.ViewGameObject;

                // TODO 子弹飞行速度
                EntityUtil.CreateBulletEntity(_contexts, playerView.Shoot.position, fireCmd.Angle.Angle2Vector2D()*5f, fireCmd.Angle);
            }
        }
    }
}