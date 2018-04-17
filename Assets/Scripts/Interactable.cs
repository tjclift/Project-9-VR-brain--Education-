using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Interactable : MonoBehaviour {

    private float distanceFromPlayer;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        distanceFromPlayer = GameVariables.DistanceFromPlayer(gameObject);
    }

    public void OnMouseEnter()
    {
        if (distanceFromPlayer < 30.0)
        {
            GameVariables.interactAttempt = true;
        }

        if (distanceFromPlayer > 30.0)
        {
            GameVariables.interactAttempt = false;
        }
    }

    public void OnMouseExit()
    {
        GameVariables.interactAttempt = false;
    }

    public GameObject prefabSphere;
    public void OnMouseUp()
    {
        try
        {
            if (GameObject.Find("Head").transform.Find("fNRIS Hat").name == "fNRIS Hat")
            {
                Debug.Log("we have ze hat");
                GameObject.Find("Eye 1").transform.localPosition = new Vector3(-0.02f, 0.18f, 1.71f);
                GameObject.Find("Eye 2").transform.localPosition = new Vector3(-0.02f, 0.18f, 3.71f);
                GameObject.Find("Mouth").transform.localPosition = new Vector3(-0.04f, 0.63f, 0.07f);
                GameObject BrainBit = (GameObject)Instantiate(Resources.Load("Sphere"));
                BrainBit.transform.position = new Vector3(0.12f, 2.01f, 2.01f);
                Destroy(GetComponent<Interactable>());
            }
                
        }
        catch(NullReferenceException e)
        {
            //do nothing
        }
    }
}
