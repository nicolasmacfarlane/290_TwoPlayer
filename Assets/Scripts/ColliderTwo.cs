using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTwo : MonoBehaviour
{        
    private UIManager ui;

    void Start()
    {
        ui = FindObjectOfType<UIManager>();
    }

    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("P1"))
        {
            ui.AddScore1();
        }
    }
}
