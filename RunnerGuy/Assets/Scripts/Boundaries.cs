using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    public static float left = -3.5f;
    public static float right = 3.5f;
    public float internalLeft;
    public float internalRight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        internalLeft = left;
        internalRight = right;
    }
}
