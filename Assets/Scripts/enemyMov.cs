using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMov : MonoBehaviour
{
    public Transform target;
    public float movSpeed; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
          return;

       transform.position = Vector3.MoveTowards(transform.position, target.position, movSpeed * Time.deltaTime);
    }
}
