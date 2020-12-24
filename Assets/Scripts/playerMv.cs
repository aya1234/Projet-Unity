using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMv : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float speed; 
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        Move();
    }
    
    private void Move()
    {
        var moveX = Input.GetAxisRaw("Horizontal");
        myrigidbody.velocity = moveX * speed*Vector2.right;
    }
}