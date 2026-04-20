using Unity.Netcode;
using UnityEngine;

public class ResourceSpawner : NetworkBehaviour
{
    [SerializeField] private NetworkObject m_woodPrefab, m_stonePrefab;

    public void SpawnResource(ObjectType type, Vector3 position)
    {
        if(IsServer == false) return;
        NetworkObject resource = type == ObjectType.Wood ? m_woodPrefab : m_stonePrefab;
        GameObject instance = Instantiate(resource.gameObject, position,
            Quaternion.Euler(0, UnityEngine.Random.Range(0, 360), 0));
        instance.GetComponent<NetworkObject>().Spawn();
    }
}