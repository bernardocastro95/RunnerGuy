using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    float speed = 3f;
    float leftRight = 4f;
    Animator anim;
    public bool hit = false;

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.left * Time.deltaTime * speed, Space.World);
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
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "obstacle")
        {
            hit = true;
            anim.SetBool("hit", hit);
        }
    }
}
