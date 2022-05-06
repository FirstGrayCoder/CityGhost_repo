using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    // Start is called before the first frame update
private void OnTriggerEnter2D(Collider2D collision)
    {  
        if (collision.tag == "Enemy")
        {
            ScoreManager.scorePlane++;
            //PlayerController2.bombNumber++;
        }
        else if (collision.tag == "Tank")
        {
            ScoreManager.scoreTank++;
        }

    }
}
