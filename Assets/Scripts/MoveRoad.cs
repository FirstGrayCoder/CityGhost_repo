using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRoad : MonoBehaviour
{
    [SerializeField]
    float _speed = 2.4f;
    public float someDistanse;
    [SerializeField]
    private SpriteRenderer _sprite;
    private Vector2 _restartPosition;
    private float _positionMinX;
    // private float back_pos;
    // void Start()
    // {
    //     _restartPosition = transform.position;
    //     _positionMinX = _sprite.bounds.size.x * 2 - _restartPosition.x;

    // }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector2.left * _speed * Time.deltaTime);
        Destroy(gameObject, 26);
        // if(transform.position.x <= someDistanse) //-18.5f
        // {
        //     transform.position = _restartPosition;
        // }
    }



}
