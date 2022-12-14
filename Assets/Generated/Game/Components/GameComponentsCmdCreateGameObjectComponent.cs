//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Components.Cmd.CreateGameObject componentsCmdCreateGameObject { get { return (Components.Cmd.CreateGameObject)GetComponent(GameComponentsLookup.ComponentsCmdCreateGameObject); } }
    public bool hasComponentsCmdCreateGameObject { get { return HasComponent(GameComponentsLookup.ComponentsCmdCreateGameObject); } }

    public void AddComponentsCmdCreateGameObject(Other.ActorTag newTag) {
        var index = GameComponentsLookup.ComponentsCmdCreateGameObject;
        var component = (Components.Cmd.CreateGameObject)CreateComponent(index, typeof(Components.Cmd.CreateGameObject));
        component.Tag = newTag;
        AddComponent(index, component);
    }

    public void ReplaceComponentsCmdCreateGameObject(Other.ActorTag newTag) {
        var index = GameComponentsLookup.ComponentsCmdCreateGameObject;
        var component = (Components.Cmd.CreateGameObject)CreateComponent(index, typeof(Components.Cmd.CreateGameObject));
        component.Tag = newTag;
        ReplaceComponent(index, component);
    }

    public void RemoveComponentsCmdCreateGameObject() {
        RemoveComponent(GameComponentsLookup.ComponentsCmdCreateGameObject);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherComponentsCmdCreateGameObject;

    public static Entitas.IMatcher<GameEntity> ComponentsCmdCreateGameObject {
        get {
            if (_matcherComponentsCmdCreateGameObject == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ComponentsCmdCreateGameObject);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherComponentsCmdCreateGameObject = matcher;
            }

            return _matcherComponentsCmdCreateGameObject;
        }
    }
}
