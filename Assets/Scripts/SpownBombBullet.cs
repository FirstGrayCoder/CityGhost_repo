using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpownBombBullet : MonoBehaviour
{
    [SerializeField] private GameObject _bomb;
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _position;
    private GameObject _newBomb;
    private GameObject _newBullet;
    public int speed;

    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Awake()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(2 * speed, rb.velocity.y);
    }

    public void FireBomb() 
    {
        if(PlayerController2.bombNumber > 0)
        { _newBomb = Instantiate(_bomb, _position.position, Quaternion.identity);
        Destroy(_newBomb, 5);
        }
    }

     public void FireBullet() 
    {
        _newBullet = Instantiate(_bullet, _position.position, Quaternion.identity);
        Destroy(_newBullet, 5);
    }


}
