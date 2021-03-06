//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity reserveSlotPositionsEntity { get { return GetGroup(GameMatcher.ReserveSlotPositions).GetSingleEntity(); } }
    public _1010C.Scripts.Components.Board.ReserveSlotPositionsComponent reserveSlotPositions { get { return reserveSlotPositionsEntity.reserveSlotPositions; } }
    public bool hasReserveSlotPositions { get { return reserveSlotPositionsEntity != null; } }

    public GameEntity SetReserveSlotPositions(UnityEngine.Vector2[] newValue) {
        if (hasReserveSlotPositions) {
            throw new Entitas.EntitasException("Could not set ReserveSlotPositions!\n" + this + " already has an entity with _1010C.Scripts.Components.Board.ReserveSlotPositionsComponent!",
                "You should check if the context already has a reserveSlotPositionsEntity before setting it or use context.ReplaceReserveSlotPositions().");
        }
        var entity = CreateEntity();
        entity.AddReserveSlotPositions(newValue);
        return entity;
    }

    public void ReplaceReserveSlotPositions(UnityEngine.Vector2[] newValue) {
        var entity = reserveSlotPositionsEntity;
        if (entity == null) {
            entity = SetReserveSlotPositions(newValue);
        } else {
            entity.ReplaceReserveSlotPositions(newValue);
        }
    }

    public void RemoveReserveSlotPositions() {
        reserveSlotPositionsEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public _1010C.Scripts.Components.Board.ReserveSlotPositionsComponent reserveSlotPositions { get { return (_1010C.Scripts.Components.Board.ReserveSlotPositionsComponent)GetComponent(GameComponentsLookup.ReserveSlotPositions); } }
    public bool hasReserveSlotPositions { get { return HasComponent(GameComponentsLookup.ReserveSlotPositions); } }

    public void AddReserveSlotPositions(UnityEngine.Vector2[] newValue) {
        var index = GameComponentsLookup.ReserveSlotPositions;
        var component = (_1010C.Scripts.Components.Board.ReserveSlotPositionsComponent)CreateComponent(index, typeof(_1010C.Scripts.Components.Board.ReserveSlotPositionsComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceReserveSlotPositions(UnityEngine.Vector2[] newValue) {
        var index = GameComponentsLookup.ReserveSlotPositions;
        var component = (_1010C.Scripts.Components.Board.ReserveSlotPositionsComponent)CreateComponent(index, typeof(_1010C.Scripts.Components.Board.ReserveSlotPositionsComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveReserveSlotPositions() {
        RemoveComponent(GameComponentsLookup.ReserveSlotPositions);
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

    static Entitas.IMatcher<GameEntity> _matcherReserveSlotPositions;

    public static Entitas.IMatcher<GameEntity> ReserveSlotPositions {
        get {
            if (_matcherReserveSlotPositions == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ReserveSlotPositions);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherReserveSlotPositions = matcher;
            }

            return _matcherReserveSlotPositions;
        }
    }
}
