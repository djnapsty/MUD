using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class redfoodUI : MonoBehaviour {


	public character player;
	public Text redfood;
	public int redfoodNUM;


	void Start () 
	{
		redfood = gameObject.GetComponent<Text> (); 

	}


	// Update is called once per frame
	void Update ()
	{
		redfoodNUM = player.redFood;
		redfood.text = "" + redfoodNUM;
	}
}