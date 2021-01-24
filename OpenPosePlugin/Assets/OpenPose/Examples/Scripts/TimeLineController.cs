using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeLineController : MonoBehaviour
{
    public float timer;
    public int objectTracker = 0;
    public float[] objectTiming;
    public GameObject[] objects;

    void Start()
    {
        timer = 0;
        cleanObjects();
        objectTracker = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        checkObjectsAwake();
    }
    public void checkObjectsAwake()
    {
        if (objects[objectTracker].activeInHierarchy == false && timer > objectTiming[objectTracker])
        {
            objects[objectTracker].SetActive(true);
            objectTracker++;
        }
    }

    public void cleanObjects()
    {
        foreach (GameObject i in objects)
        {
            i.SetActive(false);
        }
    }

    
}
