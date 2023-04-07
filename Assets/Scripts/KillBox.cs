using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    private Vector3 TeleRespawn;

    public AudioSource deathSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GameController"))
        {
            deathSound.Play();
            player.transform.position = respawnPoint.transform.position;
            Physics.SyncTransforms();
        }

    }

    public void SetSpawn(Vector3 newPosition)
    {
        TeleRespawn = newPosition;
    }

}