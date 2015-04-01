using UnityEngine;
using System.Collections;

public class Santa : Player {

	// Use this for initialization
	public void Start() {
		//Call Parents Constructor
		base.Start ();

		speed = 80f;
	}

	void FixedUpdate() {
		base.FixedUpdate ();
	}
}