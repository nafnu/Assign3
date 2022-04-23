using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slot1 : MonoBehaviour
{
    private inventory1 inventory1;
    public int i;

    void Start()
    {
        inventory1 = GameObject.FindGameObjectWithTag("Player").GetComponent<inventory1>();
    }


    void Update()
    {
        if (transform.childCount <= 0) //if there are no children, slot is item
        {
            inventory1.isFull[i] = false; //set bool to false, meaning inventory can take a new item
        }
    }

    public void DropItem() //called when x is clicked
    {
        foreach (Transform child in transform)
        {
            child.GetComponent<spawn1>().SpawnDroppedItem();
            GameObject.Destroy(child.gameObject); //check of item in slot and destroy when click X
        }
    }
}
