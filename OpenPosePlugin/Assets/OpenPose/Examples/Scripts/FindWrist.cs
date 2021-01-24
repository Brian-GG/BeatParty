using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindWrist : MonoBehaviour
{

    public Vector2 leftWristPos;

    public Vector2 rightWristPos;

    public GameObject humanContainer;

    public GameObject humanObject;

    public GameObject jointsObject;

    public GameObject poseObject;

    public GameObject leftWrist;
    public GameObject rightWrist;

    // Start is called before the first frame update
    void Start()
    {
        leftWristPos = new Vector2(0, 0);
        rightWristPos = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        humanObject = humanContainer.transform.Find("Human2D_Body25(Clone)").gameObject;

        if(humanObject != null)
        {
            jointsObject = humanObject.transform.Find("Joints").gameObject;
            if (jointsObject != null)
            {
                poseObject = jointsObject.transform.Find("Pose").gameObject;

                if(poseObject != null)
                {
                    leftWrist = poseObject.transform.Find("7_LWrist").gameObject;
                    rightWrist = poseObject.transform.Find("4_RWrist").gameObject;
                    
                    if(leftWrist != null)
                    {
                        leftWristPos = leftWrist.transform.position;
                    }
                    if(rightWrist != null)
                    {
                        rightWristPos = rightWrist.transform.position;
                    }
                }
            }
            else{ Debug.Log("No Joints here"); }
        }
        else
        { Debug.Log("No Human there");}

    }
}
