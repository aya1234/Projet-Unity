using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runscript : MonoBehaviour
{
    public Rigidbody2D myrigidBody;    
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }       

    private void Move()     
    {        
        var moveX = Input.GetAxisRaw("Horizontal");        
        myrigidBody.velocity = moveX*speed*Vector2.right;     
    }

}
