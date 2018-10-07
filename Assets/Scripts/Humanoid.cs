using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Humanoid : MonoBehaviour {

	public GameObject leg;
	public Brain brain;

	private bool kicking = false;

	private IEnumerator startKickingTimer ()
	{
		print ("Timer started");
		yield return new WaitForSeconds (5);
		print ("Timer stopped");
		kicking = false;
	}

	public void handleKneeTouch ()
	{
		print ("Knee touch event occurs");
		// start kicking action for 5 s
		kicking = true;
		StartCoroutine (startKickingTimer ());
		// send knee action event to brain
		//brain.handleKneeActionEvent ();
		// send knee action event to EEG
	}

	public void handlePinchBody ()
	{
		print ("Pinch body event occurs");
	}

	public void handleHearingSound ()
	{
		print ("Hearing sound event occurs");
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (kicking) 
		{
			leg.transform.rotation *= Quaternion.AngleAxis (1.0f, new Vector3 (1, 1, 0));	
		}
	}
}
