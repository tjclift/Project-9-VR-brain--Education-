using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cerbullum : MonoBehaviour {
	
	public Head takla;
	public Cerbullum Cerebellum;
	public Texture BrainTexture;
	public HideText text;
	public void OnTriggerEnter (Collider other)
	{
		takla.BodyColorChange ();
		print("Cer");
		this.transform.GetChild (0).gameObject.GetComponent <MeshRenderer> ().material.mainTexture = BrainTexture;
		text.JaduSee ();

	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
