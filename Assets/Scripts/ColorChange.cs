using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    bool black;


    // Use this for initialization
    void Start()
    {
        black = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))

            if (black)
            {
                GetComponent<Renderer>().material.color = new Color(255, 0, 0);
                black = false;
            }

            else if (Input.GetKeyDown(KeyCode.C))

                if (!black)
                {
                    GetComponent<Renderer>().material.color = new Color(0, 0, 255);
                    black = true;
                }


    }
}
