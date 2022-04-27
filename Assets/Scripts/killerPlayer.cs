using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class killerPlayer : MonoBehaviour
{
    Collider2D cd;
    // Start is called before the first frame update
    void Start()
    {
        cd = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene(2);
        }
    }
}
