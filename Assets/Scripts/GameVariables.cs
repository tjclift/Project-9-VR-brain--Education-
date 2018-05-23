using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameVariables : MonoBehaviour {

    public static GameObject Player;
    public static GameObject playerHoldingObject;
    public static bool playerHasObject;
    public static bool interactAttempt;

    public static float InteractRange = 3.0f;

    void Start()
    {
        //Initalize the player.
        Player = GameObject.Find("Player");
    }

    void Update()
    {
        ////Player has ability to drop what they are holding.
        if (playerHasObject)
        {
            // On left click (we dont need to look at the object to put it down)
            if (Input.GetMouseButtonDown(0) && interactAttempt == false)
            {
                //Add collisions back to this object.
                playerHoldingObject.GetComponent<Collider>().enabled = true;
                playerHoldingObject.GetComponent<Rigidbody>().isKinematic = false;
                playerHoldingObject.GetComponent<Rigidbody>().useGravity = true;

                //detach object from player
                playerHoldingObject.transform.parent = null;


                //Player is no longer holding an object
                playerHasObject = false;
                playerHoldingObject = null;
            }
        }

        //Information always faces the player.
        if (GameObject.Find("Infographic") != null)
        {
            Vector3 playerPosition = new Vector3(Player.transform.position.x, GameObject.Find("Infographic").transform.position.y, Player.transform.position.z);
            GameObject.Find("Infographic").transform.LookAt(playerPosition);
        }

    }

    public static float DistanceFromPlayer(GameObject gameobject)
    {
        return Vector3.Distance(Player.transform.position, gameobject.transform.position);
    }

}
