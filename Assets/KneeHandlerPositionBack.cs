using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KneeHandlerPositionBack : MonoBehaviour {

	public Humanoid human;

	private void OnTriggerEnter (Collider other)
	{
		print ("Knee trigger");
		// send knee touch event to human.
		human.handleKneeBrainPositionBack ();
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		
		if( Input.GetKeyDown( KeyCode.E ) )
            human.handleKneeBrainPositionBack();

	}
}

