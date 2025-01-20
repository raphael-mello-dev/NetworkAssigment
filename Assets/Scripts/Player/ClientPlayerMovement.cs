using Unity.Netcode;
using UnityEngine;

public class ClientPlayerMovement : NetworkBehaviour
{
    [SerializeField] private PlayerMovement playerMovement;

    public override void OnNetworkSpawn()
    {
        base.OnNetworkSpawn();

        if (!IsOwner)
        {
            playerMovement.enabled = false;
            return;
        }


        SpawnPaddlesServerRpc();

        playerMovement.enabled = true;
    }

    [ServerRpc(RequireOwnership = false)]
    public void SpawnPaddlesServerRpc()
    {
        if (IsHost)
        {
            transform.position = GameManager.instance.leftSpawnPoint.position;
            Debug.Log("Host spawned at " + transform.position);
        }
        else if (IsOwner)
        {
            transform.position = GameManager.instance.rightSpawnPoint.position;
            Debug.Log("Client spawned at " + transform.position);
        }

    }
}