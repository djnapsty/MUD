using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class bluefoodUI : MonoBehaviour {
	public character player;
	public Text bluefood;
	public int bluefoodNUM;


	void Start () 
	{
		bluefood = gameObject.GetComponent<Text> (); 

	}

	// Update is called once per frame
	void Update ()
	{
		bluefoodNUM = player.blueFood;

		bluefood.text = "" + bluefoodNUM;
	}
}
