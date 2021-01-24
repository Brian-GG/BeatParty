using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissScript : MonoBehaviour
{

    public float rotatePower;

    private float toTen = 20;


    // Start is called before the first frame update
    void Start()
    {
        rotatePower = 0.0f;
    }
    
    // Update is called once per frame
    void Update()
    {
        rotatePower += 10.0f / (toTen / Time.deltaTime);

        this.transform.Rotate(0.0f, 0.0f, rotatePower, Space.Self);
    }
}
