﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class AttackUI : MonoBehaviour {
	public character player;
	public int health;
	public int attack;
	public Text attackText;


	void Start () 
	{
		attackText = gameObject.GetComponent<Text> (); 

	}
	
	// Update is called once per frame
	void Update ()
	{
		
		
		health = player.defense;
		attack = player.attack;
	
		attackText.text = "" + attack;
	}
}
