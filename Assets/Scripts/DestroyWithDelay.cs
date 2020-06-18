using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWithDelay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Furnace")
        {
            Destroy(collision.gameObject); // Just destroy GameObject, without delay.

           // Destroy(gameObject, 5f); // Destroy GameObject after 5 seconds.
        }
    }
}
