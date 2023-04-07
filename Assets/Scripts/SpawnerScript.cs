using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject spherePrefab;
    public AudioSource spawnSound;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            spawnSound.Play();
            Instantiate(spherePrefab, transform.position, Quaternion.identity);
        }
    }
}
