using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBoundary = 30f;
    private float bottomBoundary = -30f;

    private void Update()
    {
        if (transform.position.z > topBoundary)
        {
            Destroy(gameObject);
        }
        if(transform.position.z < bottomBoundary){
            Destroy(gameObject);
        }
    }
}
