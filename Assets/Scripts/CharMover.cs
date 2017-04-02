using UnityEngine;
using System.Collections;

public class CharMover : MonoBehaviour {

	public float forwardVel = 12;
	public float rotationSpeed = 100;
	public float inputDelay = .01f;


	Quaternion targetRotation;
	Rigidbody rbody;

	float forwardInput, turnInput;

	public Quaternion TargetRotation {
		get { return targetRotation; }
	}

	// Use this for initialization
	void Start () {
		targetRotation = transform.rotation;
		rbody = GetComponent<Rigidbody>();
		forwardInput = 0; 
		turnInput = 0;
			

	}
	void getInput() {
		forwardInput = Input.GetAxis ("Vertical");
		turnInput = Input.GetAxis ("Horizontal");

	}

	
	// Update is called once per frame
	void Update () {
		getInput ();
		turn (); 
		//print (forwardVel);
		//print (forwardInput);
		//print (turnInput);
		//print (rbody.velocity);


	}
	void FixedUpdate () {
		run();

		}
	void run (){

		rbody.velocity = transform.forward * forwardInput * forwardVel;
	}
	void turn () {

		targetRotation *= Quaternion.AngleAxis(rotationSpeed * turnInput * Time.deltaTime, Vector3.up);
		transform.rotation = targetRotation;
		//print (targetRotation);
		//print (rotationSpeed);
		//print (Time.deltaTime);
		//print(turnInput);
	}

}



























