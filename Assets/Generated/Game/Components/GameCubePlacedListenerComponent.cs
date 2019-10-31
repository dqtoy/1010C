//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public CubePlacedListenerComponent cubePlacedListener { get { return (CubePlacedListenerComponent)GetComponent(GameComponentsLookup.CubePlacedListener); } }
    public bool hasCubePlacedListener { get { return HasComponent(GameComponentsLookup.CubePlacedListener); } }

    public void AddCubePlacedListener(System.Collections.Generic.List<ICubePlacedListener> newValue) {
        var index = GameComponentsLookup.CubePlacedListener;
        var component = (CubePlacedListenerComponent)CreateComponent(index, typeof(CubePlacedListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceCubePlacedListener(System.Collections.Generic.List<ICubePlacedListener> newValue) {
        var index = GameComponentsLookup.CubePlacedListener;
        var component = (CubePlacedListenerComponent)CreateComponent(index, typeof(CubePlacedListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveCubePlacedListener() {
        RemoveComponent(GameComponentsLookup.CubePlacedListener);
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

    static Entitas.IMatcher<GameEntity> _matcherCubePlacedListener;

    public static Entitas.IMatcher<GameEntity> CubePlacedListener {
        get {
            if (_matcherCubePlacedListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.CubePlacedListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCubePlacedListener = matcher;
            }

            return _matcherCubePlacedListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public void AddCubePlacedListener(ICubePlacedListener value) {
        var listeners = hasCubePlacedListener
            ? cubePlacedListener.value
            : new System.Collections.Generic.List<ICubePlacedListener>();
        listeners.Add(value);
        ReplaceCubePlacedListener(listeners);
    }

    public void RemoveCubePlacedListener(ICubePlacedListener value, bool removeComponentWhenEmpty = true) {
        var listeners = cubePlacedListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveCubePlacedListener();
        } else {
            ReplaceCubePlacedListener(listeners);
        }
    }
}