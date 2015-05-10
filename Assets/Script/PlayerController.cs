using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed;
	
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	void Update() {

		
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		print (moveHorizontal + "," + moveVertical);


		if (Input.GetKeyDown (KeyCode.Space)) {
			print ("space key was pressed");
			movement = new Vector3 (moveHorizontal, 40f, moveVertical);
		}
		if(Input.GetKeyDown(KeyCode.LeftShift))
			rb.velocity = Vector3.zero; 

		rb.AddForce (movement * speed);

	}


}
