using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public AudioSource killedSound;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GameController"))
        {
            killedSound.Play();
        }

    }
}
