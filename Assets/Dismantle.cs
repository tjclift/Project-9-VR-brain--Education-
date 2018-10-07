using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dismantle : MonoBehaviour {

	public GameObject switches;
	public BrainDismantle dismantle;
	int count=0;
	public void OnTriggerEnter (Collider other)
	{
		count++;
		print ("button work");
		if (count % 2 == 1) {
			dismantle.BrainPlay ();
			this.transform.GetChild (0).gameObject.GetComponent <MeshRenderer> ().material.color = new Color (0, 0, 0);
		} else {
			dismantle.BrainAssemble ();
			this.transform.GetChild (0).gameObject.GetComponent <MeshRenderer> ().material.color = new Color (1, 0, 0);
	
		}


	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
