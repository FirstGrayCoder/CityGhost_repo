using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForest : MonoBehaviour
{
    [SerializeField] private float _speed;

    void FixedUpdate()
    {
        transform.Translate(Vector2.left * _speed * Time.deltaTime);
        Destroy(gameObject, 80);

    }
}
