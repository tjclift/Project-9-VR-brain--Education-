using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Humanoid : MonoBehaviour {

	public GameObject leg;
	public Brain brain;
	public BrainL brainl;
	public BrainR brainR;
	public Stem stem;
	public StemPosition stemposition;
	public CBLMPosition cblmposition;
	public LBrain lbrainposition;
	public RBrain rbrainposition;


	private bool kicking = false;

	private IEnumerator startKickingTimer ()
	{
		print ("Timer started");
		yield return new WaitForSeconds (5);
		print ("Timer stopped");
		kicking = false;
	}

	public void handleKneeBrainPosition ()
	{
		//print ("Knee touch event occurs");
		// start kicking action for 5 s
		//kicking = true;
		//StartCoroutine (startKickingTimer ());
		// send knee action event to brain
		stemposition.handleKneeActionEvent ();
		cblmposition.handleKneeActionEvent ();
		lbrainposition.handleKneeActionEvent ();
		rbrainposition.handleKneeActionEvent ();
		//brainl.handleKneeActionEvent ();
		//brainR.handleKneeActionEvent ();
		//stem.handleKneeActionEvent ();
		// send knee action event to EEG
	}
	
	public void handleKneeBrainPositionBack ()
	{
		//print ("Knee touch event occurs");
		// start kicking action for 5 s
		//kicking = true;
		//StartCoroutine (startKickingTimer ());
		// send knee action event to brain
		stemposition.handleKneeActionEventBack ();
		cblmposition.handleKneeActionEventBack ();
		lbrainposition.handleKneeActionEventBack ();
		rbrainposition.handleKneeActionEventBack ();
		//brainl.handleKneeActionEvent ();
		//brainR.handleKneeActionEvent ();
		//stem.handleKneeActionEvent ();
		// send knee action event to EEG
	}

	public void handleKneeTouchStem ()
	{
		print ("Knee touch event occurs");
		// start kicking action for 5 s
		kicking = true;
		StartCoroutine (startKickingTimer ());
		// send knee action event to brain
		brain.handleKneeActionEvent ();
		//brainl.handleKneeActionEvent ();
		//brainR.handleKneeActionEvent ();
		stem.handleKneeActionEvent ();
		// send knee action event to EEG
	}

	public void handleKneeTouchBrainL ()
	{
		print ("Knee touch event occurs");
		// start kicking action for 5 s
		kicking = true;
		StartCoroutine (startKickingTimer ());
		// send knee action event to brain
		//brain.handleKneeActionEvent ();
		brainl.handleKneeActionEvent ();
		//brainR.handleKneeActionEvent ();
		//stem.handleKneeActionEvent ();
		// send knee action event to EEG
	}

	public void handleKneeTouchBrainR ()
	{
		print ("Knee touch event occurs");
		// start kicking action for 5 s
		kicking = true;
		StartCoroutine (startKickingTimer ());
		// send knee action event to brain
		//brain.handleKneeActionEvent ();
		//brainl.handleKneeActionEvent ();
		brainR.handleKneeActionEvent ();
		//stem.handleKneeActionEvent ();
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
