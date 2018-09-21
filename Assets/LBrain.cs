using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LBrain : MonoBehaviour {


	Vector3 tempPos;

	public void handleKneeActionEvent ()
	{
		print ("Brain Position Changed");
		tempPos = transform.position;

		tempPos.x = -0.95f;

		transform.position = tempPos;
		//tempPos.x += 0.04f;
		//this.transform.GetChild (0).position = tempPos ;
		//this.transform.GetChild (1).position = new Vector3 (0.0f, 1.5f,0.0f);
		//this.transform.GetChild (2).position = new Vector3 (0.0f, 1.5f,0.0f);
		//this.transform.GetChild (3).position = new Vector3 (0.0f, 1.5f,0.0f);
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
