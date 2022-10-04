//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Components.VelocityComponent componentsVelocity { get { return (Components.VelocityComponent)GetComponent(GameComponentsLookup.ComponentsVelocity); } }
    public bool hasComponentsVelocity { get { return HasComponent(GameComponentsLookup.ComponentsVelocity); } }

    public void AddComponentsVelocity(UnityEngine.Vector2 newValue) {
        var index = GameComponentsLookup.ComponentsVelocity;
        var component = (Components.VelocityComponent)CreateComponent(index, typeof(Components.VelocityComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceComponentsVelocity(UnityEngine.Vector2 newValue) {
        var index = GameComponentsLookup.ComponentsVelocity;
        var component = (Components.VelocityComponent)CreateComponent(index, typeof(Components.VelocityComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveComponentsVelocity() {
        RemoveComponent(GameComponentsLookup.ComponentsVelocity);
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

    static Entitas.IMatcher<GameEntity> _matcherComponentsVelocity;

    public static Entitas.IMatcher<GameEntity> ComponentsVelocity {
        get {
            if (_matcherComponentsVelocity == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ComponentsVelocity);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherComponentsVelocity = matcher;
            }

            return _matcherComponentsVelocity;
        }
    }
}
