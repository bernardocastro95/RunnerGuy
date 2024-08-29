using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed = 3f;
    float leftRight = 4f;
    public Animator anim;
    public bool hit;
    public float distanceAchievedMilestone;
    private float milestoneCount;
    private float increaseSpeed;
    public float multiplier;
    public bool jumping, landing = false;
    public GameObject player;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed, Space.World);
        speedUp();
        if (hit == false)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                if (this.gameObject.transform.position.z > Boundaries.left)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftRight);
                }
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                if (this.gameObject.transform.position.z < Boundaries.right)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftRight * -1);
                }
            }
        }
        

    }

    void speedUp()
    {
        if(transform.position.x < distanceAchievedMilestone)
        {
            milestoneCount += distanceAchievedMilestone;
            distanceAchievedMilestone = distanceAchievedMilestone * multiplier;
            speed *= multiplier;
        }

        
    }

    void jump()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            if(jumping == false)
            {
                jumping = true;
                player.GetComponent<Animator>().Play("Jump");
            }
            
        }
        else
        {
            
        }
    }

}
