using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    [SerializeField] string coin;
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
        Managers.Inventory.AddItem(coin);

        if (other.gameObject.GetComponent<PlayerOne>())
        {
            oneCoins += 1;
            Debug.Log ("Player one has " + oneCoins + " coins!");
        }

        if (other.gameObject.GetComponent<PlayerTwo>())
        {
            twoCoins += 1;
            Debug.Log ("Player two has " + twoCoins+ " coins!");
        }

        Destroy (this.gameObject);
    }
}
