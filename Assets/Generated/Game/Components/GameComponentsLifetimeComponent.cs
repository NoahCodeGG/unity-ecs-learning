//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Components.Lifetime componentsLifetime { get { return (Components.Lifetime)GetComponent(GameComponentsLookup.ComponentsLifetime); } }
    public bool hasComponentsLifetime { get { return HasComponent(GameComponentsLookup.ComponentsLifetime); } }

    public void AddComponentsLifetime(float newTime) {
        var index = GameComponentsLookup.ComponentsLifetime;
        var component = (Components.Lifetime)CreateComponent(index, typeof(Components.Lifetime));
        component.Time = newTime;
        AddComponent(index, component);
    }

    public void ReplaceComponentsLifetime(float newTime) {
        var index = GameComponentsLookup.ComponentsLifetime;
        var component = (Components.Lifetime)CreateComponent(index, typeof(Components.Lifetime));
        component.Time = newTime;
        ReplaceComponent(index, component);
    }

    public void RemoveComponentsLifetime() {
        RemoveComponent(GameComponentsLookup.ComponentsLifetime);
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

    static Entitas.IMatcher<GameEntity> _matcherComponentsLifetime;

    public static Entitas.IMatcher<GameEntity> ComponentsLifetime {
        get {
            if (_matcherComponentsLifetime == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ComponentsLifetime);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherComponentsLifetime = matcher;
            }

            return _matcherComponentsLifetime;
        }
    }
}
