using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	//Physics Data
    protected float friction;
	protected float speed;
	protected Rigidbody physicsBody;

	// Use this for initialization
    public void Start()
    {
        physicsBody = GetComponent<Rigidbody>();

		friction = 0.5f;
		speed = 300f;
    }

	// Update is called once per frame
    public void Update()
    {

    }
    
	public void FixedUpdate() 
    {
		//Apply Friction
		physicsBody.velocity = new Vector3(physicsBody.velocity.x * friction, physicsBody.velocity.y, physicsBody.velocity.z * friction);

		//Do the player Movement
		DoMovement (speed);

		//Temp Test for knockback
		if (Input.GetKeyDown (KeyCode.Space) == true) 
		{
			physicsBody.velocity += new Vector3(200, 0, 0);
			Debug.Log("Knocked Back");
		}
	}

	public void DoMovement(float _speed)
	{
		float dt = Time.deltaTime;
		Vector3 currentVel = physicsBody.velocity;

		//input checks
		if (Input.GetKey(KeyCode.W) == true && currentVel.z < speed)
		{
			physicsBody.velocity += Vector3.forward * _speed * dt;
			Debug.Log("UP");
		}
		if (Input.GetKey(KeyCode.S) == true && currentVel.z > -speed)
		{
			physicsBody.velocity += Vector3.back * _speed * dt;
			Debug.Log("DOWN");
		}
		if (Input.GetKey(KeyCode.A) == true && currentVel.x > -speed)
		{
			physicsBody.velocity += Vector3.left * _speed * dt;
			Debug.Log("LEFT");
		}
		if (Input.GetKey(KeyCode.D) == true && currentVel.x < speed)
		{
			physicsBody.velocity += Vector3.right * _speed * dt;
			Debug.Log("RIGHT");
		}
	}
}
