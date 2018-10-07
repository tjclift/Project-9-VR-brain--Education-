using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torso2 : MonoBehaviour {

	public void BodyColorChange()
	{
		this.transform.gameObject.GetComponent <MeshRenderer> ().material.color = new Color (0, 0, 1);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
