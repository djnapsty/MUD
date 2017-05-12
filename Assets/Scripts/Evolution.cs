using UnityEngine;
using System.Collections;

public class Evolution : MonoBehaviour {


	public GameObject[] avatar;
	public character player;
	Vector3 playerPosition;
	public Quaternion playerRotation;
	public Vector3 offsetFromTarget = new Vector3 (0, 16, -8);


	// Use this for initialization
	void Start () 
	{
		
		Instantiate (avatar [player.charLevel], playerPosition + offsetFromTarget, playerRotation);

	}
	
	// Update is called once per frame
	void Update () 
	{
		playerRotation = player.playerRotation;
		playerPosition = player.transform.position;
		avatar[player.charLevel].gameObject.transform.position = player.transform.position;



		//if (player.charLevel == 1)
			
		
	}
}
