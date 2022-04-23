using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyOpen : MonoBehaviour
{

    public GameObject door;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(door);
            Destroy(gameObject);
        }
    }
}
