//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public DragStartedListenerComponent dragStartedListener { get { return (DragStartedListenerComponent)GetComponent(GameComponentsLookup.DragStartedListener); } }
    public bool hasDragStartedListener { get { return HasComponent(GameComponentsLookup.DragStartedListener); } }

    public void AddDragStartedListener(System.Collections.Generic.List<IDragStartedListener> newValue) {
        var index = GameComponentsLookup.DragStartedListener;
        var component = (DragStartedListenerComponent)CreateComponent(index, typeof(DragStartedListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceDragStartedListener(System.Collections.Generic.List<IDragStartedListener> newValue) {
        var index = GameComponentsLookup.DragStartedListener;
        var component = (DragStartedListenerComponent)CreateComponent(index, typeof(DragStartedListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveDragStartedListener() {
        RemoveComponent(GameComponentsLookup.DragStartedListener);
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

    static Entitas.IMatcher<GameEntity> _matcherDragStartedListener;

    public static Entitas.IMatcher<GameEntity> DragStartedListener {
        get {
            if (_matcherDragStartedListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.DragStartedListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherDragStartedListener = matcher;
            }

            return _matcherDragStartedListener;
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

    public void AddDragStartedListener(IDragStartedListener value) {
        var listeners = hasDragStartedListener
            ? dragStartedListener.value
            : new System.Collections.Generic.List<IDragStartedListener>();
        listeners.Add(value);
        ReplaceDragStartedListener(listeners);
    }

    public void RemoveDragStartedListener(IDragStartedListener value, bool removeComponentWhenEmpty = true) {
        var listeners = dragStartedListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveDragStartedListener();
        } else {
            ReplaceDragStartedListener(listeners);
        }
    }
}