using Unity.Netcode;
using UnityEngine;

public class PickableBase : NetworkBehaviour, IInteractable
{
    protected NetworkVariable<bool> isAvailable = new(
        true,
        NetworkVariableReadPermission.Everyone,
        NetworkVariableWritePermission.Owner
    );
    public void ToggleSelection (bool usSelected)
    {
        throw new System.NotImplementedException();
    }
}
