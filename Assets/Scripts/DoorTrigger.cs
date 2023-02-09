using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Door door;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "GameController")
        {
            door.up = true;

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "GameController")
        {
            door.up = false;

        }
    }
}
