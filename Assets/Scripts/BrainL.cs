using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainL : MonoBehaviour {

	public HideText1 text01;
	public BodyR bodyr;
	public BrainL Brain;
	public Texture BrainTexture;

	public void OnTriggerEnter (Collider other)
	{
		bodyr.BodyColorChange ();
		print("BrainL");
		this.transform.GetChild (0).gameObject.GetComponent <MeshRenderer> ().material.mainTexture = BrainTexture;
		this.transform.GetChild (1).gameObject.GetComponent <MeshRenderer> ().material.mainTexture = BrainTexture;
		this.transform.GetChild (2).gameObject.GetComponent <MeshRenderer> ().material.mainTexture = BrainTexture;
		this.transform.GetChild (3).gameObject.GetComponent <MeshRenderer> ().material.mainTexture = BrainTexture;
		this.transform.GetChild (4).gameObject.GetComponent <MeshRenderer> ().material.mainTexture = BrainTexture;
		text01.JaduSee ();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
