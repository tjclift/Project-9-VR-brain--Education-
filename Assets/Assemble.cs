using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assemble : MonoBehaviour {

	public BrainDismantle dismantle;

	public void OnTriggerEnter (Collider other)
	{
		print ("button work");
		dismantle.BrainAssemble();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
