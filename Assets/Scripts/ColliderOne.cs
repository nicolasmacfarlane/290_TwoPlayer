using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderOne : MonoBehaviour
{        
    private UIManager ui;

    void Start()
    {
        ui = FindObjectOfType<UIManager>();
    }

    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("P2"))
        {
            ui.AddScore2();
        }
    }
}
