﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Sign : Objects
{
    // public GameObject player;
    //public GameObject dialogBox;
    //public Text dialogText;
    //public string dialog;
    //public bool playerInRange;
    private PlayerInteraction player;
    
   

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerInteraction>();

    }

    // Update is called once per frame
    void Update()
    {

        //string playerstate = GameObject.FindWithTag("Player").GetComponent<Animator>().GetCurrentAnimatorClipInfo(0)[0].clip.name;
        //bool playerFacingUp;
        //if (playerstate == "IdleUp" | playerstate == "WalkUp")
        //{
        //    playerFacingUp = true;
        //}
        //else
        //{
        //    playerFacingUp = false;
        //}
        if (player.interactionButtonWasPressed)
        {
            buttonFingerSign();
            player.interactionButtonWasPressed = false;
        }





        if (Input.GetKeyDown(KeyCode.Space) && playerInRange) //&& playerFacingUp
        {
            if (dialogBox.activeInHierarchy)
            {
                dialogBox.SetActive(false);
            }
            else
            {
                dialogBox.SetActive(true);
                dialogText.text = dialog;
            }
        }

    }

    
    public void buttonFingerSign()
    {
        if (playerInRange) //&& playerFacingUp
        {
            if (dialogBox.activeInHierarchy)
            {
                dialogBox.SetActive(false);
            }
            else
            {
                dialogBox.SetActive(true);
                dialogText.text = dialog;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {


        if (other.CompareTag("Player")) 
        {
            
            playerInRange = true;   

        }       
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            dialogBox.SetActive(false);
        }
    }


}
