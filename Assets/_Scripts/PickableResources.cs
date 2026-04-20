using UnityEngine;

public class PickableResources : PickableBase
{
    protected override void ApplyAvailabilityState(bool newValue)
    {
        //no code
    }

    protected override void OnPickedUp()
    {
        if (IsServer == false)
            return;
        NetworkObject.Despawn();
    }
}