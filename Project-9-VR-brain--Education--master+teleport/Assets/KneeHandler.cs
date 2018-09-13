using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KneeHandler : MonoBehaviour {

	public Humanoid human;

	private void OnTriggerEnter (Collider other)
	{
		print ("Knee trigger");
		// send knee touch event to human.
		human.handleKneeTouch ();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
