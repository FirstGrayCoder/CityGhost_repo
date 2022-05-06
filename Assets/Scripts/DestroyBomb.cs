using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBomb : MonoBehaviour
{
    private SpownBombBullet bomb;
    public DestroyTank tankHP;
    public GameObject effectLand;
    public GameObject neweffectLand;
    public GameObject effectTank;
    public GameObject neweffectTank;
    //public ScoreManager sm;


    void OnTriggerEnter2D (Collider2D collision) {
        if (collision.tag == "Tank") 
        {
            Destroy(gameObject);
            neweffectTank = Instantiate(effectTank, transform.position, Quaternion.identity);
            collision.GetComponent<DestroyTank>().TakeDemage();
            Destroy(neweffectTank, 1);
            
        }
        else if (collision.tag == "Enemy") 
        {
            Destroy(gameObject);
            neweffectTank = Instantiate(effectTank, transform.position, Quaternion.identity);
            collision.GetComponent<DestroyTank>().TakeDemage();
            Destroy(neweffectTank, 1);
            
        }
        else if (collision.tag == "ground") 
        {
            Destroy(gameObject);
            neweffectLand = Instantiate(effectLand, transform.position, Quaternion.identity);
            Destroy(neweffectLand, 1);
           
        }
    }

}
