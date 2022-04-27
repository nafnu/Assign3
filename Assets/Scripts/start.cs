using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using EZCameraShake;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    cameras camPlayer;
    [SerializeField] string nameFocus = null;
    [SerializeField] float speedChange;
    [SerializeField] GameObject cam = null;

    private inventory1 inventory1;
    public int i;

    // Start is called before the first frame update
    void Start()
    {
        inventory1 = GameObject.FindGameObjectWithTag("Player").GetComponent<inventory1>();

        camPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<cameras>();
        if (!camPlayer)
            Debug.LogWarning(name + "Not Found Object");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag(nameFocus))
        {
            camPlayer.ChangeCamera(speedChange);
            cam.SetActive(true);
        }

       
        if (collision.CompareTag("Player"))
        {
            if (transform.childCount <= 0) //if there are no children, slot is item
            {
                inventory1.isFull[i] = true; //set bool to false, meaning inventory can take a new item
                Debug.LogWarning(name + "Need more ballons");
            }
            else if (transform.childCount <= 1)
            {
                inventory1.isFull[i] = false;
                SceneManager.LoadScene(3);
            }
           
         }


        /*
   if (collision.tag == "GameController")
   {
       life.GetComponent<Point>().point += pointsOffer;
       Destroy(gameObject);
   }
        */

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(nameFocus))
        {
            cam.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
