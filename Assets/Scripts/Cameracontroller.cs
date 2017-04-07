using UnityEngine;
using System.Collections;


public class Cameracontroller : MonoBehaviour {

	public Transform target;
	public float looksmooth = .09f;
	public Vector3 offsetFromTarget = new Vector3 (0, 6, -8);
	public float xTilt = 10f; //not currently used

	Vector3 destination = Vector3.zero;
	CharMover mover;
	float rotationSpeed = 0;


	void Start () 
	{
		setCameraTarget (target);
	}



	void setCameraTarget (Transform t) 
	{
		target = t;
		mover = target.GetComponent<CharMover>();
	}

	

	void LateUpdate () 
	{
		moveToTarget ();
		LookAtTarget ();
	}



	void moveToTarget () 
	{
		destination = mover.TargetRotation * offsetFromTarget;
		destination += target.position;
		transform.position = destination;
	}




	void LookAtTarget()
	{
		float eulerYAngle = Mathf.SmoothDampAngle(transform.eulerAngles.y, target.eulerAngles.y, ref rotationSpeed, looksmooth);
		transform.rotation = Quaternion.Euler(transform.eulerAngles.x, eulerYAngle,0);

	}


}
