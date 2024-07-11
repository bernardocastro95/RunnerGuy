using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed = 3f;
    float leftRight = 4f;
    public Animator anim;
    public bool hit;

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.left * Time.deltaTime * speed, Space.World);
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


}
