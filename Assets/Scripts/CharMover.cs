﻿using UnityEngine;
using System.Collections;

public class CharMover : MonoBehaviour {
	const float grow = .005f;
	public float forwardVel = 10;
	public float rotationSpeed = 100;
	public float inputDelay = .01f;
	public character Player;
	Animation anim;



	Quaternion targetRotation;
	Rigidbody rbody;

	float forwardInput, turnInput;

	public Quaternion TargetRotation 
	{
		get { return targetRotation; }
	}

	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animation>();
		targetRotation = transform.rotation;
		rbody = GetComponent<Rigidbody>();
		forwardInput = 0; 
		turnInput = 0;
	}



	void getInput() 
	{
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
	void FixedUpdate () 
	{
		run();

	}


	void run ()
	{
		rbody.velocity = transform.forward * forwardInput * forwardVel;


	
		//run animation
		if (forwardInput > inputDelay) 
		{
			anim.Play ("move");
		}
		if (forwardInput < inputDelay) 
		{
			anim.Play ("idle");
		}
	
	
	
	}


	void turn () 
	{
		targetRotation *= Quaternion.AngleAxis(rotationSpeed * turnInput * Time.deltaTime, Vector3.up);
		transform.rotation = targetRotation;
		//print (targetRotation);
		//print (rotationSpeed);
		//print (Time.deltaTime);
		//print (turnInput);
	}




	void OnCollisionEnter(Collision collision) {

		if (collision.gameObject.tag == "BlueFood") 
		{
			Player.blueFood++; //add one to blueFood
			Player.gameObject.transform.localScale += new Vector3(grow, grow, grow);
			Destroy(collision.gameObject);
		
		}

		if(collision.gameObject.tag == "RedFood") 
		{
			Player.redFood++;
			//float playerScaleX = Player.transform.localScale.x;
			Player.gameObject.transform.localScale += new Vector3(grow, grow, grow);
			Destroy(collision.gameObject);

		}

		if(collision.gameObject.tag == "GreenFood") 
		{
			Player.greenFood++;
			Player.gameObject.transform.localScale += new Vector3(grow, grow, grow);
			Destroy(collision.gameObject);

		}

	}

}























