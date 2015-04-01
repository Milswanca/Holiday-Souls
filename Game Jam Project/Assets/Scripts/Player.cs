using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
    //input commands
    KeyCode up;
    KeyCode down;
    KeyCode left;
    KeyCode right;

    //positional data
    public float Friction = 0.5f;
    Rigidbody physicsBody;

	// Use this for initialization
    void Start()
    {
        physicsBody = GetComponent<Rigidbody>();
    }

	// Update is called once per frame
    void Update()
    {

    }
    
    void FixedUpdate() 
    {
        physicsBody.velocity = new Vector3(physicsBody.velocity.x * Friction, physicsBody.velocity.y, physicsBody.velocity.z * Friction);

        Vector3 velocity = physicsBody.velocity;

	    //input checks
        if (Input.GetKey(KeyCode.W) == true && velocity.z < 1)
        {
            physicsBody.velocity += Vector3.forward;
            //Debug.Log("UP");
        }
        if (Input.GetKey(KeyCode.S) == true && velocity.z > -1)
        {
            physicsBody.velocity += Vector3.back;
            //Debug.Log("DOWN");
        }
        if (Input.GetKey(KeyCode.A) == true && velocity.x > -1)
        {
            physicsBody.velocity += Vector3.left;
            //Debug.Log("LEFT");
        }
        if (Input.GetKey(KeyCode.D) == true && velocity.x < 1)
        {
            physicsBody.velocity += Vector3.right;
           //Debug.Log("RIGHT");
        }

        
	}
}
