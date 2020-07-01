using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterOnceCollision : MonoBehaviour
{
    private bool hasEntered;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("player") && !hasEntered)
        {
            hasEntered = true;
            
        }
    }
}
