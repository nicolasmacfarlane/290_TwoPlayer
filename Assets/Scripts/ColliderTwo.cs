using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTwo : MonoBehaviour
{        
    private static int oneScore;

    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("P1"))
        {
            oneScore += 1;
            Debug.Log("Player one has jumped " + oneScore + " times!");
        }
    }
}
