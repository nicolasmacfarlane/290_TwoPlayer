using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderOne : MonoBehaviour
{        
    private static int twoScore;

    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("P2"))
        {
            twoScore += 1;
            Debug.Log("Player two has jumped " + twoScore + " times!");
        }
    }
}
