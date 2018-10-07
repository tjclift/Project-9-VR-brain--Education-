using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainR : MonoBehaviour {

	public HideText text;
	public BodyL Human;
	public BrainR Brain;
	public Texture BrainTexture;

	public void OnTriggerEnter (Collider other)
	{
		Human.BodyColorChange ();
		print("BrainR");
		this.transform.GetChild (0).gameObject.GetComponent <MeshRenderer> ().material.mainTexture = BrainTexture;
		this.transform.GetChild (1).gameObject.GetComponent <MeshRenderer> ().material.mainTexture = BrainTexture;
		this.transform.GetChild (2).gameObject.GetComponent <MeshRenderer> ().material.mainTexture = BrainTexture;
		this.transform.GetChild (3).gameObject.GetComponent <MeshRenderer> ().material.mainTexture = BrainTexture;
		this.transform.GetChild (4).gameObject.GetComponent <MeshRenderer> ().material.mainTexture = BrainTexture;

		text.JaduSee ();



	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
