using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stem : MonoBehaviour {

	public Torso1 torso1;
	public Torso2 torso2;
	public HideText text;
	public Stem brainstem;
	public Texture BrainTexture;

	public void OnTriggerEnter (Collider other)
	{
		torso1.BodyColorChange ();
		torso2.BodyColorChange ();
		print("Stem");
		this.transform.GetChild (0).gameObject.GetComponent <MeshRenderer> ().material.mainTexture = BrainTexture;
		this.transform.GetChild (1).gameObject.GetComponent <MeshRenderer> ().material.mainTexture = BrainTexture;
		this.transform.GetChild (2).gameObject.GetComponent <MeshRenderer> ().material.mainTexture = BrainTexture;
		text.JaduSee();

	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
