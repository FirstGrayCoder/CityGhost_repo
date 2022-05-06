using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBot : MonoBehaviour
{
    [SerializeField] private GameObject _tank;
    public float speed = 0.03f;
    public Transform posit;
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        _tank.transform.Translate(new Vector2(-1f, 0f).normalized * speed);
        posit = GetComponent<Transform>();
    }
        void OnTriggerEnter2D (Collider2D collision) {
        if (collision.tag == "Plane") 
        {
            Destroy(gameObject);
        }
    }
}
