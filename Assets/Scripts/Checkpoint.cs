using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    Vector3 spawnPoint;
    [SerializeField] private Transform player;
    KillBox respawnPoint;
    public AudioSource checkpointSound;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < 37f)
        {
            gameObject.transform.position = spawnPoint;
        }
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "CheckPoint")
        {
            checkpointSound.Play();
            spawnPoint = other.gameObject.transform.position;
            Destroy(other.gameObject);
        }

    }
}
