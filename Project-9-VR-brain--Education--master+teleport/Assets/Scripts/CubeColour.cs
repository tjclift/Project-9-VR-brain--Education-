using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColour : MonoBehaviour {

    public Color clickedColour;
    public Color clickedColour2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnMouseEnter()
    {
        
    }

    public void OnMouseExit()
    {

    }

    public void OnMouseUp()
    {
        if (gameObject.GetComponent<Renderer>().material.color == clickedColour)
        {
            gameObject.GetComponent<Renderer>().material.color = clickedColour2;
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = clickedColour;
        }
        
    }
}
