//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Components.Position componentsPosition { get { return (Components.Position)GetComponent(GameComponentsLookup.ComponentsPosition); } }
    public bool hasComponentsPosition { get { return HasComponent(GameComponentsLookup.ComponentsPosition); } }

    public void AddComponentsPosition(UnityEngine.Vector2 newValue) {
        var index = GameComponentsLookup.ComponentsPosition;
        var component = (Components.Position)CreateComponent(index, typeof(Components.Position));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceComponentsPosition(UnityEngine.Vector2 newValue) {
        var index = GameComponentsLookup.ComponentsPosition;
        var component = (Components.Position)CreateComponent(index, typeof(Components.Position));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveComponentsPosition() {
        RemoveComponent(GameComponentsLookup.ComponentsPosition);
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

    static Entitas.IMatcher<GameEntity> _matcherComponentsPosition;

    public static Entitas.IMatcher<GameEntity> ComponentsPosition {
        get {
            if (_matcherComponentsPosition == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ComponentsPosition);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherComponentsPosition = matcher;
            }

            return _matcherComponentsPosition;
        }
    }
}
