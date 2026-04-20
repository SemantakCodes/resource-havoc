using Unity.Netcode;
using UnityEngine;

public interface IInteractable
{
    void ToggleSelection(bool usSelected);
    NetworkObject NetworkObject {get;}
}
