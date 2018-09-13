using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Interactable : MonoBehaviour {

    public enum Selection
    {
        PickupableObject,
        AttachToThisObject,
        Trigger_Brain,
        ProjectorToggle,
        Targetable,
        BreakModelBrain
    };

    public Selection ScriptType;

    private float distanceFromPlayer;
    public GameObject attachableObject;
    public bool InfoExists = false;
    public bool isTargeted = false;
    public bool m_isAxisInUse = false;

    public Material originalMaterial;

    // Use this for initialization
    void Start() {
        originalMaterial = gameObject.GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        distanceFromPlayer = GameVariables.DistanceFromPlayer(gameObject);
        //Determine if player is looking at object.

        if (gameObject.name.ToString() == "Frontal Lobe (Left)")
        {
            //
        }

        if (RaycastTesting.hitObject == gameObject)
        {
            Debug.Log("Hitting: " + gameObject.name.ToString());
            GameVariables.interactAttempt = true;
            isTargeted = true;

            //If it is a brain component - Outline it.

            if (ScriptType == Selection.Targetable && isTargeted == true)
            {
                // Store the original material to change back.
                if (gameObject.GetComponent<Renderer>().material != Resources.Load("Outlined", typeof(Material)) as Material)
                {
                    gameObject.GetComponent<Renderer>().material = Resources.Load("Outlined", typeof(Material)) as Material;
                }

                else if (gameObject.GetComponent<Renderer>().material == Resources.Load("Outlined", typeof(Material)) as Material)
                {
                    // Do nothing
                }
            }

            if (Input.GetAxisRaw("openvr-r-trigger-press") !=0)
            {
                if(m_isAxisInUse == false)
                {

                    OnMouseUp();
                    m_isAxisInUse = true;
                }
            }

            if ( Input.GetAxisRaw("openvr-r-trigger-press") == 0)
            {
                m_isAxisInUse = false;
            }

        }

        else if (RaycastTesting.hitObject != gameObject || RaycastTesting.hitObject == null)
        {
            gameObject.GetComponent<Renderer>().material = originalMaterial;
            GameVariables.interactAttempt = false;
            isTargeted = false;
        }

        //Same as on mouse exist

        //if (isTargeted == false)
        //{
        //    GameVariables.interactAttempt = false;
        //    if (ScriptType == Selection.Targetable)
        //    {
        //        gameObject.GetComponent<Renderer>().material = originalMaterial;

        //        if (InfoExists == true)
        //        {
        //            try
        //            {

        //            }
        //            catch (NullReferenceException e)
        //            {
        //                //Do nothing.
        //            }
        //        }

        //    }
        //}

    }


    //If the mouse enters this object, assume an attempt to interact.
    //public void OnMouseEnter()
    //{
    //    if (distanceFromPlayer < 30.0)
    //    {
    //        GameVariables.interactAttempt = true;

    //        //If it is a brain component - Outline it.

    //        if (ScriptType == Selection.Targetable)
    //        {
    //            // Store the original material to change back.
    //            originalMaterial = gameObject.GetComponent<Renderer>().material;

    //            Material outlinedMaterial = Resources.Load("Outlined", typeof(Material)) as Material;
    //            gameObject.GetComponent<Renderer>().material = outlinedMaterial;
    //        }
    //    }

    //    if (distanceFromPlayer > 30.0)
    //    {
    //        GameVariables.interactAttempt = false;
    //    }
    //}

    //public void OnMouseExit()
    //{
    //    GameVariables.interactAttempt = false;
    //    if (ScriptType == Selection.Targetable)
    //    {
    //        gameObject.GetComponent<Renderer>().material = originalMaterial;

    //        if (InfoExists == true)
    //        {
    //            try
    //            {
    //             //   Destroy(GameObject.Find("Infographic"));
    //            //    InfoExists = false;
    //            }
    //            catch (NullReferenceException e)
    //            {
    //                //Do nothing.
    //            }
    //        }

    //    }
            
 
    //}

    public void OnMouseUp()
    {
            switch (ScriptType)
            {
                case Selection.PickupableObject:
                    PickupableObject();
                    break;

                case Selection.AttachToThisObject:
                    AttachToThisObject();
                    break;

                case Selection.Trigger_Brain:
                    TriggerBrain();
                    break;

                case Selection.ProjectorToggle:
                    ProjectorToggle();
                    break;

                case Selection.Targetable:
                    Infographic(gameObject);
                    break;

                case Selection.BreakModelBrain:
                    BreakModelBrain();
                    break;
            }
    }




    // = = = = = = = = = = = = //
    // Unique Events Go Here! //
    // = = = = = = = = = = = = //

    public void PickupableObject()
    {
        if (!GameVariables.playerHasObject && distanceFromPlayer < GameVariables.InteractRange)

        {
            //Remove physics from this object.
            this.GetComponent<Collider>().enabled = false;
            this.GetComponent<Rigidbody>().isKinematic = true;
            this.GetComponent<Rigidbody>().useGravity = false;

            //attach object to the player.
            transform.parent = GameVariables.Player.transform;
            this.transform.localPosition = new Vector3(0.63f, 0.25f, 1.20f);
            this.transform.localEulerAngles = new Vector3(0, 0, 0);

            //Player is now holding an object
            GameVariables.playerHasObject = true;
            GameVariables.playerHoldingObject = gameObject;
        }
    }

    public void AttachToThisObject()
    {
        //Find out if the player is holding an object.
        if (GameVariables.playerHoldingObject == attachableObject && distanceFromPlayer < GameVariables.InteractRange)
        {
            //Player is no longer holding the object.
            GameVariables.playerHasObject = false;

            //Store the game object locally otherwise later we will be referencing a null object.
            GameObject holdingObject = GameVariables.playerHoldingObject;

            //Remove object from the player (Do we need this?)
            //   GameVariables.playerHoldingObject.transform.parent = null;

            //Attach the object to this object
            holdingObject.transform.parent = transform;
            holdingObject.transform.localPosition = new Vector3(0.002f, 0.391f, 0.017f);
            holdingObject.transform.localEulerAngles = new Vector3(0, 0, 0);

        }
    }

    public void TriggerBrain()
    {
        try
        {
                GameObject BrainBit = (GameObject)Instantiate(Resources.Load("brain2_prefab"));
                BrainBit.transform.position = new Vector3(0.11f, 3.71f, -0.57f);
                BrainBit.transform.Rotate(0f, 180f, 0f);
                Destroy(GetComponent<Interactable>());

        }
        catch (NullReferenceException e)
        {
            //do nothing
        }

        return;
    }


    public void ProjectorToggle()
    {
        if (attachableObject.active == true)
        {
            attachableObject.active = false;
        }
        else
        {
            attachableObject.active = true;
        }
        
    }

    public void Infographic(GameObject partSelected)
    {
        if (InfoExists != true)
        {
            GameObject InfoGraphic = (GameObject)Instantiate(Resources.Load("Infographic"));

            switch (partSelected.name.ToString())
            {
                case "Left Hemisphere":
                    InfoGraphic.transform.position = new Vector3(2.1478f, 5.028f, -3.4474f);
                    GameObject.Find("Infographic-text").GetComponent<TextMesh>().text = partSelected.name.ToString();
                    InfoGraphic.transform.parent = partSelected.transform;
                    break;

                case "Frontal Lobe (Left)":
                    InfoGraphic.transform.position = new Vector3(-2.08f, 4.95f, -3.06f);
                    GameObject.Find("Infographic-text").GetComponent<TextMesh>().text = partSelected.name.ToString();
                    InfoGraphic.transform.parent = partSelected.transform;
                    break;

                case "Frontal Lobe (Right)":
                    InfoGraphic.transform.position = new Vector3(-1.273f, 5.502f, -1.636f);
                    GameObject.Find("Infographic-text").GetComponent<TextMesh>().text = partSelected.name.ToString();
                    InfoGraphic.transform.parent = partSelected.transform;
                    break;

                case "Right Hemisphere":
                    InfoGraphic.transform.position = new Vector3(1.719f, 5.502f, -1.636f);
                    GameObject.Find("Infographic-text").GetComponent<TextMesh>().text = partSelected.name.ToString();
                    InfoGraphic.transform.parent = partSelected.transform;
                    break;



            }
            InfoGraphic.name = "Infographic";
            InfoExists = true;
        }
        else
        {
            try
            {
                Destroy(GameObject.Find("Infographic"));
                InfoExists = false;

            }
            catch (NullReferenceException e)
            {
                //Do nothing.
            }
        }
        
    }

    public void BreakModelBrain()
    {
        try
        {
            Destroy(GameObject.Find("flesh5Main1"));
            Destroy(GameObject.Find("flesh5Main"));
            Destroy(GameObject.Find("flesh4Main1"));
            Destroy(GameObject.Find("flesh3Main"));
            Destroy(GameObject.Find("flesh3Main1"));
            Destroy(GameObject.Find("flesh4Main1"));
            Destroy(GameObject.Find("pSphere6 1"));
            Destroy(GameObject.Find("flesh4Main"));

            GameObject.Find("flesh1Main1").transform.localPosition = new Vector3(0.0194f, 0.0522f, -0.0328f);
            GameObject.Find("flesh2Main1").transform.localPosition = new Vector3(0.01158895f, 0.05097441f, -0.032f);
            GameObject.Find("Left Hemisphere").transform.localPosition = new Vector3(235235f,235235f, 23523f);
            GameObject.Find("flesh1Main").transform.localPosition = new Vector3(0.0235f, 0.0529f, -0.0112f);
            GameObject.Find("pSphere6").transform.localPosition = new Vector3(0.0519f, 0.015f, 0f);

            GameObject.Find("brain1").transform.localPosition = new Vector3(-0.0334f, -0.0428f, -0.0071f);


        }

        catch (NullReferenceException e)
        {
            //Do nothing
        }
    }

}
