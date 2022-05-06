using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGround : MonoBehaviour
{
    public GameObject ground;
    public GameObject ground2;
    public float x;
    public float y;
    public float x2;
    public float y2;
    public float speed;
    public float speedCorutine1;
    public float speedCorutine2;
void Start()
    {
        StartCoroutine(Spawner());
        StartCoroutine(Spawner2());
        //speed = Random.Range(-0.5f, 3.5f);
    }
    IEnumerator Spawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(speedCorutine1);
            GameObject newGround = Instantiate(ground, new Vector2(x, y), Quaternion.identity);
            speedCorutine1 = 18;
            
            Destroy(newGround, 40);

        }
    }
    IEnumerator Spawner2()
    {
        while (true)
        {
            yield return new WaitForSeconds(speedCorutine1);
            GameObject newGround2 = Instantiate(ground2, new Vector2(x2, y2), Quaternion.identity);
            Destroy(newGround2, 40);
        }
    }

    // void FixedUpdate()
    // {
    //     transform.Translate(Vector2.left * speed * Time.deltaTime);
    // }
}
