//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Components.Target componentsTarget { get { return (Components.Target)GetComponent(GameComponentsLookup.ComponentsTarget); } }
    public bool hasComponentsTarget { get { return HasComponent(GameComponentsLookup.ComponentsTarget); } }

    public void AddComponentsTarget(int newTargetId) {
        var index = GameComponentsLookup.ComponentsTarget;
        var component = (Components.Target)CreateComponent(index, typeof(Components.Target));
        component.TargetId = newTargetId;
        AddComponent(index, component);
    }

    public void ReplaceComponentsTarget(int newTargetId) {
        var index = GameComponentsLookup.ComponentsTarget;
        var component = (Components.Target)CreateComponent(index, typeof(Components.Target));
        component.TargetId = newTargetId;
        ReplaceComponent(index, component);
    }

    public void RemoveComponentsTarget() {
        RemoveComponent(GameComponentsLookup.ComponentsTarget);
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

    static Entitas.IMatcher<GameEntity> _matcherComponentsTarget;

    public static Entitas.IMatcher<GameEntity> ComponentsTarget {
        get {
            if (_matcherComponentsTarget == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ComponentsTarget);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherComponentsTarget = matcher;
            }

            return _matcherComponentsTarget;
        }
    }
}