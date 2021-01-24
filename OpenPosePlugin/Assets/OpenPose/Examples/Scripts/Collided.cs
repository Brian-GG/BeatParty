using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collided : MonoBehaviour
{

    public Vector2 circlePos;

    public Vector2 circleRadius;

    public FindWrist findWrist;

    public Vector2 leftWristPos;

    public Vector2 rightWristPos;

    public ScoreController scoring;

    public float timeToAppear = 0.9f;

    public float hitLeniency = 1f;

    public float timer = 0f;

    public GameObject miss;

    // Start is called before the first frame update
    void Start()
    {
        circlePos = this.transform.position;
        circleRadius = this.transform.localScale;
        this.transform.localScale = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        rightWristPos = findWrist.rightWristPos;
        leftWristPos = findWrist.leftWristPos;


        if (circleRadius.x <= this.transform.localScale.x)
        {
            if (System.Math.Sqrt(System.Math.Pow((circlePos.x - findWrist.rightWristPos.x), 2) + System.Math.Pow((circlePos.y - findWrist.rightWristPos.y), 2)) <= (circleRadius.x / 2)
            || System.Math.Sqrt(System.Math.Pow((circlePos.x - findWrist.leftWristPos.x), 2) + System.Math.Pow((circlePos.y - findWrist.leftWristPos.y), 2)) <= (circleRadius.x / 2)
                )
            {
                
                scoring.Score += (int)(100 * scoring.scoreMulti);
                scoring.scoreMulti += 0.06f;

                Debug.Log("Hit");
                Destroy(gameObject);


            }
            else if(timer>=hitLeniency)
            {
                scoring.scoreMulti = 1f;
                Instantiate(miss, new Vector2(circlePos.x, circlePos.y), this.transform.rotation);
                Debug.Log("Miss");
                Destroy(gameObject);
            }
            else
            {
                timer += Time.deltaTime;
            }
        }
        else
        {
            this.transform.localScale += new Vector3(circleRadius.x/(timeToAppear/Time.deltaTime) , circleRadius.x / (timeToAppear / Time.deltaTime), 0);
        }
    }
}
