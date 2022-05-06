using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Tank")
        {  
            ScoreManager.scoreTank++;
            //ScoreManager.bestscoreTank++;
            PlayerController2.bombNumber--;
       
        }
        else if (collision.tag == "Enemy")
        {

            ScoreManager.scorePlane++;
            //ScoreManager.bestscorePlane++;
            
        }
        else if (collision.tag == "ground")
        {  
            PlayerController2.bombNumber--;
       
        }


    }
}
