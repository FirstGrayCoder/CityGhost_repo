using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController2 : MonoBehaviour
{
    public float speed = 1f;
    public int bombMax;
    [SerializeField] private int dir;
    public Rigidbody2D rb;
    public  GameObject gb;
    public GameObject restartPanel;
    public Text bombCount;
    public Text bombMaxText;
    public GameObject effectTank;
    public GameObject neweffectTank;    
    public static int bombNumber;
    
    public ParticleSystem effectSmoke;
    private Transform thisTrans;
    private int Dir =1;
    

    //public Vector2 Dir;
    // Start is called before the first frame update
    void Start()
    {
        thisTrans = GetComponent<Transform>();
        effectSmoke.Play(true);
        bombNumber = 10;
        bombMax = 10;
        
        rb = GetComponent<Rigidbody2D>();
        //gb = GetComponent<GameObject>();
        // restartPanel.SetActive(false);
        // gb.SetActive(true);
    }

    public void Rotation() 
    {
        float angle = thisTrans.localRotation.eulerAngles.z;
             if((angle>0f && angle<70) || (angle>270f && angle<360)){
                thisTrans.Rotate(0, 0, 150f * Dir * Time.deltaTime);
            }
    }

    
    public void FixedUpdate()
    {
        if (ScoreManager.bestscorePlane == 20)
        {
            bombMax = 20;
        }
        else if (ScoreManager.bestscorePlane == 30)
        {
            bombMax = 30;
        }
        //Rotation();
        if (bombNumber <= 0 ) 
        {
            bombNumber = 0;
        }
        if (ScoreManager.LoseNumber == 10) 
        {
            restartPanel.SetActive(true);
            Destroy(gameObject);
        } 
        rb.velocity = new Vector2(rb.velocity.x, dir * speed) ;

        bombCount.text = bombNumber.ToString();
        bombMaxText.text = bombMax.ToString();
        // if(dir > 0 && rb.rotation < 20) {
        //     rb.rotation++;
        // }
        // else if(dir < 0 && rb.rotation > -20) {
        //     rb.rotation--;
        // }

    }// Update is called once per frame
    
    public void ChangedDir(int buttonDir) {

        dir = buttonDir;

        // if(dir > 0 || rb.rotation < 20) {
        //     rb.rotation++;
        // }
        // if(dir < 0) {
        //     rb.rotation = -3;
        // }
    }

    public void RestLevel() 
    {
        restartPanel.SetActive(false);
        gb.SetActive(true);
        ScoreManager.LoseNumber = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Gift")
        {  
            bombNumber = bombNumber + 5;
            if (bombNumber > bombMax) 
            {
                bombNumber = bombMax;
            }
        }
        if (collision.tag == "Enemy") 
        {
            Destroy(gameObject);
            neweffectTank = Instantiate(effectTank, transform.position, Quaternion.identity);
            collision.GetComponent<DestroyTank>().TakeDemage();
            Destroy(neweffectTank, 1);
            ScoreManager.scorePlane++;
            restartPanel.SetActive(true);
        }
        else if (collision.tag == "Tank") 
        {
            Destroy(gameObject);
            neweffectTank = Instantiate(effectTank, transform.position, Quaternion.identity);
            collision.GetComponent<DestroyTank>().TakeDemage();
            Destroy(neweffectTank, 1);
            ScoreManager.scoreTank++;
            restartPanel.SetActive(true);
        }
        else if (collision.tag == "ground") 
        {
            Destroy(gameObject);
            neweffectTank = Instantiate(effectTank, transform.position, Quaternion.identity);
            Destroy(neweffectTank, 1);
            new WaitForSeconds(1f);
            restartPanel.SetActive(true);
        }

    }
    
}
