using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    public static int points = 0;
    public static int life = 3;
    public static int maxScore = 10;
    public static int minLife = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        points = 0; //set both scores to zero at game start/reset 
        life = 3;
    }
}
