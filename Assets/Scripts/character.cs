using UnityEngine;
using System.Collections;

public class character : MonoBehaviour {

	public int charLevel;
	public int redFood;
	public int blueFood;
	public int greenFood;
	public int attack;
	public int defense;
	public int levelTarget;
	public int greenLevelTarget;
	public int blueLevelTarget;
	public GameObject playerAvatar;
	public Quaternion playerRotation;

	void awake ()
	{
		attack = 1;
		defense = 1;

	}

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{

		this.gameObject.transform.position = playerAvatar.gameObject.transform.position;
	
	}
}
