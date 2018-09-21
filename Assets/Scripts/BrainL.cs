using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainL : MonoBehaviour {

	public void handleKneeActionEvent ()
	{
		this.transform.GetChild (0).gameObject.GetComponent <MeshRenderer> ().material.color = new Color (0, 0, 1);
		this.transform.GetChild (1).gameObject.GetComponent <MeshRenderer> ().material.color = new Color (0, 0, 1);
		this.transform.GetChild (2).gameObject.GetComponent <MeshRenderer> ().material.color = new Color (0, 0, 1);
		this.transform.GetChild (3).gameObject.GetComponent <MeshRenderer> ().material.color = new Color (0, 0, 1);
		this.transform.GetChild (4).gameObject.GetComponent <MeshRenderer> ().material.color = new Color (0, 0, 1);
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
