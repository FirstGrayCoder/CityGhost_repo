using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpownGift : MonoBehaviour
{
    public GameObject gift;
    public float speed;
    private GameObject newGift;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawner());
        speed = Random.Range(-0.5f, 3.5f);
    }

    void OnTriggerEnter2D (Collider2D collision) {
        if (collision.tag == "Plane") 
        {
            Destroy(gameObject);
        }
    }


    IEnumerator Spawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(30f);
            newGift = Instantiate(gift, new Vector2(12f, speed), Quaternion.identity);
            Destroy(newGift, 17);
        }
    }
        public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //ScoreManager.scorePlane = 0;
        
    }

}
