using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public Character player;
    public GameObject model;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            this.GetComponent<BoxCollider>().enabled = false;
            player.hit = true;
            player.speed = 0;
            model.GetComponent<Animator>().Play("Stumble");
        }

    }
}