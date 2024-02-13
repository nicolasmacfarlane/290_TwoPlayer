using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public GameObject coin;
    float rotateSpeed = 100f;
    Vector3 rotationDirection = new Vector3(0, 0, 1);

    private static int oneCoins;
    private static int twoCoins;
    void Update()
    {
        transform.Rotate(rotateSpeed * rotationDirection * Time.deltaTime);
    }

    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.GetComponent<PlayerOne>())
        {
            Destroy(coin);
            oneCoins += 1;
            Debug.Log ("Player one has " + oneCoins + " coins!");
        }

        if (other.gameObject.GetComponent<PlayerTwo>())
        {
            Destroy(coin);
            twoCoins += 1;
            Debug.Log ("Player two has " + twoCoins+ " coins!");
        }
    }
}
