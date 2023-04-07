using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPointManager : MonoBehaviour
{
    GameObject nextCheckPoint;

    public GameObject reference;
    GameObject parent;

    public List<GameObject> checkPointList;

    int numberOfCheckpoints;

    void Start()
    {
        checkPointList = new List<GameObject>();

        parent = transform.gameObject;
        numberOfCheckpoints = parent.transform.childCount;

        for (int i = 0; i < numberOfCheckpoints; i++)
        {
            Transform subject = parent.transform.GetChild(i);
            GameObject subjectGO = subject.gameObject;
            checkPointList.Add(subjectGO);
        }

        for (int i = 1; i < checkPointList.Count; i++)
        {
            GameObject deactivateMe = checkPointList[i];
            deactivateMe.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public GameObject GetNextCheckpoint()
    {
        return checkPointList[0];
    }

    public void NextWaypoint(GameObject input)
    {
        reference = input;

        reference.SetActive(false);

        checkPointList.Remove(reference);
        checkPointList.Add(reference);

        checkPointList[0].SetActive(true);
    }
}
