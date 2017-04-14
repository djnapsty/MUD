using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class greenfoodUI : MonoBehaviour {


public character player;
public Text greenfood;
public int greenfoodNUM;


	void Start () 
	{
		greenfood = gameObject.GetComponent<Text> (); 
	
	}


	// Update is called once per frame
	void Update ()
	{
		greenfoodNUM = player.greenFood;
		greenfood.text = "" + greenfoodNUM + " / " + player.greenLevelTarget;
	}
}
