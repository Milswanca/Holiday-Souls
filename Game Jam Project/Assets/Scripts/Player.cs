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
    public void Start()
    {
        up = KeyCode.W;
        down = KeyCode.S;
        left = KeyCode.A;
        right = KeyCode.D;
        physicsBody = GetComponent<Rigidbody>();
    }

	// Update is called once per frame
    public void Update()
    {

    }
    
    public void FixedUpdate() 
    {
        physicsBody.velocity = new Vector3(physicsBody.velocity.x * Friction, physicsBody.velocity.y, physicsBody.velocity.z * Friction);

        Movement();
	}

    void Movement()
    {
        Vector3 velocity = physicsBody.velocity;



        //input checks
        if (Input.GetKey(up) == true && velocity.z < 1)
        {
            physicsBody.velocity += Vector3.forward;
            //Debug.Log("UP");
        }
        if (Input.GetKey(down) == true && velocity.z > -1)
        {
            physicsBody.velocity += Vector3.back;
            //Debug.Log("DOWN");
        }
        if (Input.GetKey(left) == true && velocity.x > -1)
        {
            physicsBody.velocity += Vector3.left;
            //Debug.Log("LEFT");
        }
        if (Input.GetKey(right) == true && velocity.x < 1)
        {
            physicsBody.velocity += Vector3.right;
            //Debug.Log("RIGHT");
        }
        if (Input.GetKey(KeyCode.O) == true)
        {
            BasicAttack();
        }
        if (Input.GetKey(KeyCode.P) == true)
        {
            SpecialAttack();
        }
    }

    void Combat()
    {
        
    }

    void BasicAttack()
    {
        physicsBody.velocity += Vector3.forward * 5;
    }
    
    void SpecialAttack()
    {
        physicsBody.velocity += Vector3.forward * 15;
    }
}
