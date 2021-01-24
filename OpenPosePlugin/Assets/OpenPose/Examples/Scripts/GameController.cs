using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public OpenPose.Example.OpenPoseUserScript poseScript;

    public AudioSource rasputin;

    // Start is called before the first frame update
    void Start()
    {
        poseScript.ToggleRenderBgImg();
        poseScript.maxPeople = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
