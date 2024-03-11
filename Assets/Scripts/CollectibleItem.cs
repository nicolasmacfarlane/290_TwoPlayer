using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    private UIManager ui;
    [SerializeField] string coin;
    float rotateSpeed = 100f;
    Vector3 rotationDirection = new Vector3(0, 0, 1);

    void Start()
    {
        ui = FindObjectOfType<UIManager>();
    }

    void Update()
    {
        transform.Rotate(rotateSpeed * rotationDirection * Time.deltaTime);
    }

    private void OnTriggerEnter (Collider other)
    {
        Managers.Inventory.AddItem(coin);

        if (other.gameObject.GetComponent<PlayerOne>())
        {
            ui.AddScore1();
            Debug.Log ("Player one got a point");
        }

        if (other.gameObject.GetComponent<PlayerTwo>())
        {
            ui.AddScore2();
            Debug.Log ("Player two got a point");
        }

        Destroy (this.gameObject);
    }
}
