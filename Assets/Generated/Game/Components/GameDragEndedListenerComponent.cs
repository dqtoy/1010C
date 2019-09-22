//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public DragEndedListenerComponent dragEndedListener { get { return (DragEndedListenerComponent)GetComponent(GameComponentsLookup.DragEndedListener); } }
    public bool hasDragEndedListener { get { return HasComponent(GameComponentsLookup.DragEndedListener); } }

    public void AddDragEndedListener(System.Collections.Generic.List<IDragEndedListener> newValue) {
        var index = GameComponentsLookup.DragEndedListener;
        var component = (DragEndedListenerComponent)CreateComponent(index, typeof(DragEndedListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceDragEndedListener(System.Collections.Generic.List<IDragEndedListener> newValue) {
        var index = GameComponentsLookup.DragEndedListener;
        var component = (DragEndedListenerComponent)CreateComponent(index, typeof(DragEndedListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveDragEndedListener() {
        RemoveComponent(GameComponentsLookup.DragEndedListener);
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

    static Entitas.IMatcher<GameEntity> _matcherDragEndedListener;

    public static Entitas.IMatcher<GameEntity> DragEndedListener {
        get {
            if (_matcherDragEndedListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.DragEndedListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherDragEndedListener = matcher;
            }

            return _matcherDragEndedListener;
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

    public void AddDragEndedListener(IDragEndedListener value) {
        var listeners = hasDragEndedListener
            ? dragEndedListener.value
            : new System.Collections.Generic.List<IDragEndedListener>();
        listeners.Add(value);
        ReplaceDragEndedListener(listeners);
    }

    public void RemoveDragEndedListener(IDragEndedListener value, bool removeComponentWhenEmpty = true) {
        var listeners = dragEndedListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveDragEndedListener();
        } else {
            ReplaceDragEndedListener(listeners);
        }
    }
}