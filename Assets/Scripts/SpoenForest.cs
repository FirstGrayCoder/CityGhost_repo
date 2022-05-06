using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpoenForest : MonoBehaviour
{
    [SerializeField] private float speedCorutine;
    [SerializeField] private GameObject _forest;

    [SerializeField] private float x;
    [SerializeField] private float y;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawner());
    }
    IEnumerator Spawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(speedCorutine);
            GameObject newGround2 = Instantiate(_forest, new Vector2(x, y), Quaternion.identity);
            speedCorutine = 25;
            //Destroy(newGround2, 60f);
        }
    }
}
