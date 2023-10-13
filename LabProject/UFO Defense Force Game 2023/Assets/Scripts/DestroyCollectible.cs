using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCollectible : MonoBehaviour
{
    public float topBounds = 30.0f;

    public float lowerBounds = -10.0f;

    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
    }
}
