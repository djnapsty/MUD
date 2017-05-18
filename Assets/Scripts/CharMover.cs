using UnityEngine;
using System.Collections;
//using UnityEditor.Audio;
using UnityEngine.SceneManagement;

public class CharMover : MonoBehaviour {
	const float grow = .002f;
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
		rbody = GetComponent<Rigidbody>();

		targetRotation = transform.rotation;
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
		ScalePlayer ();
		setTargetRotation ();
		//print (forwardVel);
		//print (forwardInput);
		//print (turnInput);
		//print (rbody.velocity);

		if (Player.defense <= 0) {
			SceneManager.LoadScene (2);
		}


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
		if (forwardInput < inputDelay && forwardInput != 0) 
		{
			anim.Play ("idle");
		}
		if (forwardInput == 0.0f) 
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

		if (collision.gameObject.tag == "BlueFood") {
			Player.blueFood++; //add one to blueFood
			Player.gameObject.transform.localScale += new Vector3 (grow, grow, grow);
			Destroy (collision.gameObject);
		
		}

		if (collision.gameObject.tag == "RedFood") {
			Player.redFood++;
			Player.gameObject.transform.localScale += new Vector3 (grow, grow, grow);
			Destroy (collision.gameObject);

		}

		if (collision.gameObject.tag == "GreenFood") {
			Player.greenFood++;
			Player.gameObject.transform.localScale += new Vector3 (grow, grow, grow);
			Destroy (collision.gameObject);

		}




		if (collision.gameObject.tag == "roach") {
			Destroy (collision.gameObject);
			AudioSource audio = GetComponent<AudioSource> ();
			audio.Play ();
			Player.redFood += 5;
			Player.greenFood += 5;
			Player.blueFood += 5;
			Player.defense += 1;

		}




		if (collision.gameObject.tag == "snail") {
			Destroy (collision.gameObject);
			AudioSource audio = GetComponent<AudioSource> ();
			audio.Play ();
			Player.redFood += 5;
			Player.greenFood += 5;
			Player.blueFood += 5;
			Player.defense += 1;

		}





		if (collision.gameObject.tag == "snake") {
			Player.defense -= 1;

			if (Player.attack > 3) {
				Destroy (collision.gameObject);
				AudioSource audio = GetComponent<AudioSource> ();
				audio.Play ();
				Player.redFood += 10;
				Player.greenFood += 10;
				Player.blueFood += 10;
			}
		}
				



		if (collision.gameObject.tag == "lobster") {
			Player.defense -= 2;

			if (Player.attack > 5) {
				Destroy (collision.gameObject);
				AudioSource audio = GetComponent<AudioSource> ();
				audio.Play ();
				Player.redFood += 20;
				Player.greenFood += 20;
				Player.blueFood += 20;
			}

		}


		if (collision.gameObject.tag == "spider") {
			Player.defense -= 1;

			if (Player.attack > 3) {
				Destroy (collision.gameObject);
				AudioSource audio = GetComponent<AudioSource> ();
				audio.Play ();
				Player.redFood += 10;
				Player.greenFood += 10;
				Player.blueFood += 10;
			}
		}
	
	
	
	
	}			
	void ScalePlayer()
	{
		this.gameObject.transform.localScale = Player.gameObject.transform.localScale;
	}

	void setTargetRotation()
	{
		Player.playerRotation = targetRotation;
	}



}


	




















