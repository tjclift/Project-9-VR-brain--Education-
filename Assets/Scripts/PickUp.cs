using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

    // Get the distance between the attached object and the player.
    public float distance;
    public Transform player; // This is the reference object (player)

    // Set a variable pickup range
    public float pickupRange = 3.0f;

	
	// Update is called once per frame
	void Update ()
    {
        // Distance between the object and the position
        distance = Vector3.Distance(player.transform.position, transform.position);
    }

    public void OnMouseEnter()
    {

    }

    public void OnMouseExit()
    {

    }

    public void OnMouseUp()
    {
        // First make sure the object isn't already attached to the player and the player is within proximity.
        if (!PlayerHolding.hasObject && distance < pickupRange )
            
        {
            //Remove physics from this object.
            this.GetComponent<Collider>().enabled = false;
            this.GetComponent<Rigidbody>().isKinematic = true;
            this.GetComponent<Rigidbody>().useGravity = false;

            //attach object to the player.
            transform.parent = player.transform;
            this.transform.localPosition = new Vector3(0.63f, 0.25f, 0.85f);

            //Player is now holding an object
            PlayerHolding.hasObject = true;
            PlayerHolding.holdingObject = this.gameObject;
        }

    }
}

