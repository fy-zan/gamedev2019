using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PlayerInteraction : MonoBehaviour
{
   
    public GameObject currentInterObj = null;
    //public Button InteractionButton;

    public Button InteractionButton = null; 
    //GameObject.FindWithTag("InteractionButton");
    public bool interactionButtonWasPressed;

    


    private void Start()
    {
        InteractionButton = GameObject.Find("Interaction Button").GetComponent<Button>();
        interactionButtonWasPressed = false;
    }

    private void Update()
    {
        if(interactionButtonWasPressed)
        {
            Debug.Log("kam huwa");
            //currentInterObj.SendMessage("DoInteraction");
            //interactionButtonWasPressed = false;
        }

            //  Input.GetKeyDown(KeyCode.Space)
        if (Input.GetKeyDown(KeyCode.Space) && currentInterObj)
        {
            //do something with the obj
            //currentInterObj.SendMessage("DoInteraction");
            currentInterObj = null;
        }
    }


    public void DoInteraction()
    {
        Debug.Log("button dba");
        interactionButtonWasPressed = true;
        //currentInterObj.SendMessage("DoInteraction");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {


        if(other.CompareTag("InterObj"))
        {
            Debug.Log(other.name);
            currentInterObj = other.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("InterObj"))
        {
            if (other.gameObject == currentInterObj)
            {
                currentInterObj = null;
            }
        }
       
        
    }

}
