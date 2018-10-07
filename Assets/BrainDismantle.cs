using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainDismantle : MonoBehaviour {


	public Animator Anime;

	public void BrainPlay ()
	{
		print ("play works");

		Anime.Play ("Dismantle");

	}

	public void BrainAssemble ()
	{
		print ("play works");

		Anime.Play ("Assemble");
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
