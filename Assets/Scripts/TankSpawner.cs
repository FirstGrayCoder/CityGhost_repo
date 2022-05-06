using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    // public bool StopGame = false;
    
    // Start is called before the first frame update
    public GameObject tank;
    public GameObject plane;
    public float speed;
    public float speed2;
    public Vector2 Dir;
    // public Transform posit;
    private GameObject newTank;
    private GameObject newPlane;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawner());
        StartCoroutine(Spawner2());
        speed = 12f;
    }
//     private void FixedUpdate()
//     {
// if (TankHealth < 1) {
//     Destroy(newTank, 1);
// }
//     }

    IEnumerator Spawner()
    {
        while (true)
        {
            
            yield return new WaitForSeconds(speed);
            newTank = Instantiate(tank, new Vector2(13.42f, -1.84f), Quaternion.identity);
            Destroy(newTank, 12);
            if (speed > 3f)
            {
            speed = speed - 0.05f;
            }
        }
    }

        IEnumerator Spawner2()
    {
        while (true)
        {
            //float rand1 = Random.Range(3f, 9f);
            yield return new WaitForSeconds(speed);

            float rand = Random.Range(-0.84f, 3.5f);
            newPlane = Instantiate(plane, new Vector2(13.42f, rand), Quaternion.identity);
            Destroy(newPlane, 20);
            if(speed > 3f)
            {
            speed = speed - 0.3f;
            }
        }
    }
}
