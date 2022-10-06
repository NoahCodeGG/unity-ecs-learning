using Entitas;
namespace Systems
{
    public class SyncPosition : IExecuteSystem
    {

        private readonly IGroup<GameEntity> _group;
        
        public SyncPosition(Contexts contexts)
        {
            _group = contexts.game.GetGroup(GameMatcher.AllOf(
                GameMatcher.ComponentsView,
                GameMatcher.ComponentsPosition,
                GameMatcher.ComponentsTagsPhysicsTag
                ));
        }
        
        public void Execute()
        {
            foreach (var gameEntity in _group.GetEntities()) {
                var position = gameEntity.componentsView.ViewGameObject.transform.position;
                gameEntity.ReplaceComponentsPosition(position);
            }
        }
    }
}