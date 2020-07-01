using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSystem : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D col)
    {
        GameControl.health -= 1;
    }
}

//Everything below was an attempt at three different ways to write a bool statement to check if colliders interact but only once. This was to try to get hearts to only decrease by one per enemy hit.
//Legs had 2 box colliders

//public class DamageSystem : MonoBehaviour
//{
//    void OnTriggerEnter(Collider other)
//    {
//        other.hitCount++;
//        if (other.hitCount == 1)
//        {
//            GameControl.health -= 1;
//            //  enemy.doStuff();
//        }
//    }

//    void OnTriggerExit(Collider other)
//    {
//        other.hitCount--;
//        if (other.hitCount < 0)
//        {
//            other.hitCount = 0;
//        }
//    }
//}

//    private bool isColliding = false;

//    void OnTriggerEnter2D(Collider2D col)
//    {
//        if (isColliding) return;
//        {
//            isColliding = true;
//            GameControl.health -= 1;
//            Debug.Log("Trigger!");
//            StartCoroutine(Reset());
//        }

//    }

//    IEnumerator Reset()
//    {
//        yield return new WaitForEndOfFrame();
//        isColliding = false;
//    }
//}


//public class DamageSystem : MonoBehaviour
//{
//    private bool hasEntered;

//    void OnCollisionEnter(Collision other)
//    {
//        if (other.gameObject.CompareTag("player") && !hasEntered)
//        {
//            hasEntered = true;
//            GameControl.health -= 1;
//        }
//    }
//}