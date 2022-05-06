using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DestroyTank : MonoBehaviour
{
    public GameObject tank;
    public int health = 1;
    private ScoreManager sm;

    // Start is called before the first frame update

       void Start() 
    {
       sm = GetComponent<ScoreManager>();
      
    }    
    void FixedUpdate()
    {

        if (health < 1) {
            Destroy(gameObject);
        }
        //sm.ScorecountTank();

    }

    // Update is called once per fram

    public void TakeDemage() {
        health = 0;
        
    }
}
