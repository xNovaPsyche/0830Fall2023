using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public static event Action OnCollected;

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnCollected?.Invoke();
            Destroy(gameObject);
        }
    }
}