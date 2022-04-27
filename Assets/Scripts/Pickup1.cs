using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup1 : MonoBehaviour
{
    private inventory1 inventory1;
    public GameObject itemButton;
    void Start()
    {
        inventory1 = GameObject.FindGameObjectWithTag("Player").GetComponent<inventory1>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < inventory1.slots.Length; i++)
            {
                if (inventory1.isFull[i] == false)
                {
                    //item can be added to inventory
                    inventory1.isFull[i] = true; //set current slot to true
                    Instantiate(itemButton, inventory1.slots[i].transform, false); //create itembutton at slot position
                    Destroy(gameObject); //destroy pickup in world
                    break;
                }

             }

         }

        if (other.CompareTag("GameController"))
        {
            GameObject.Destroy(gameObject);
         
        }
    }
}
