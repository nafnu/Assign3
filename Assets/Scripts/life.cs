using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class life : MonoBehaviour
{
    public Text points;
    public Text life2;
    public Text winner;



    void Start()
    {
        winner.GetComponent<UnityEngine.UI.Text>().text = " ";
        

    }

   
    void Update()
    {
        //access text property of UI Text
        //points.GetComponent<UnityEngine.UI.Text>().text = "Points:  " + Arkball.points.ToString();

        life2.GetComponent<UnityEngine.UI.Text>().text = "Life:  " + playerEle.life.ToString();

        PlayerWins(); //call function to check winner

    }

    
   void PlayerWins()
   {
        /*
       if (Arkball.points >= Arkball.maxScore) //winning goal set at 5 for player 1
       {
           winner.GetComponent<UnityEngine.UI.Text>().text = "PLAYER WINS \n(press R to restart)";

       }*/
       if (playerEle.life < playerEle.minLife) //winning goal set at 5 for player 2
       {
            SceneManager.LoadScene(2);
        }

   }
   }
   


