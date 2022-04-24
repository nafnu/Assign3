using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyOpen : MonoBehaviour
{

    public GameObject[] doors;
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (GameObject door in doors)
            {
                Destroy(door);
            }
            Destroy(gameObject);
        }
    }
}
