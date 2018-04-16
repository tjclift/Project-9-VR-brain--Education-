using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachMe : MonoBehaviour {

    // The object(s) which we are allowed to attach here.
    public GameObject attachableObject;


    // To make sure the player is within a suitable range to attach the fNRIS hat.
    private float distance;
    private GameObject player;
    public float attachRange = 3.0f;

    // Use this for initialization
    void Start ()
    {
        //Initalize the player.
        player = GameObject.Find("Player");
    }
	
	// Update is called once per frame
	void Update ()
    {
        distance = Vector3.Distance(player.transform.position, transform.position);
    }

    public void OnMouseDown()
    {
        //Find out if the player is holding an object.
        if (PlayerHolding.holdingObject == attachableObject && distance < attachRange)
        {
            //Player is no longer holding the object.
            PlayerHolding.hasObject = false;

            //Store the game object locally otherwise later we will be referencing a null object.
            GameObject holdingObject = PlayerHolding.holdingObject;

            //Remove object from the player (Do we need this?)
            holdingObject.transform.parent = null;

            //Attach the object to this object
            holdingObject.transform.parent = transform;
            holdingObject.transform.localPosition = new Vector3(0.002f, 0.391f, 0.017f);
            holdingObject.transform.localEulerAngles = new Vector3(0, 0, 0);

        }
    }
}
