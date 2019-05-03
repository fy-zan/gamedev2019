using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransportTile : Objects
{
    //Attributes
    public GameObject TileToTransport;
    public GameObject TileToTransport2;
    public GameObject TileToTransport3;
    public GameObject canv;
    //public GameObject dialogBox;// = canv.gameObject.transform.GetChild(0).gameObject;
    //private bool playerInRange;
    public string areaname;
    public int privAccess;
    public PlayerInteraction player;

    //Methods
    void Start()
    {
        //InteractionButton.onClick.AddListener(TaskOnClick);
        //dialogBox = canv.gameObject.transform.GetChild(0).gameObject;
         dialogBox.SetActive(false);
        player = FindObjectOfType<PlayerInteraction>();
    }
    void Update()
    {

        if (player.interactionButtonWasPressed)
        {
            buttonFinger();
            player.interactionButtonWasPressed = false;
        }






        if (playerInRange && Input.GetKeyDown(KeyCode.Space))
        {
            GameObject player = GameObject.FindWithTag("Player");
            if (player.GetComponent<PlayerAttributes>().priv == privAccess)

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



                //        //player.transform.position = TileToTransport.transform.position;
            }

        }

     }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") )
        { 
                playerInRange = true;
        }

    }
    public void OnTriggerExit2D(Collider2D other)

    {
        
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            dialogBox.SetActive(false);
        }
    }
    public void buttonFinger()

    {
        Debug.Log("Entering Work");
        if (playerInRange)
        {
            Debug.Log("You have clicked the button!");
            GameObject player = GameObject.FindWithTag("Player");
            if (player.GetComponent<PlayerAttributes>().priv == privAccess)
            {
                //Debug.Log("You have clicked the button!");
                if (dialogBox.activeInHierarchy)
                {
                    Debug.Log("You have clicked the button!");
                    dialogBox.SetActive(false);
                }
                else
                {
                    dialogBox.SetActive(true);
                    dialogText.text = dialog;
                }



                //player.transform.position = TileToTransport.transform.position;
            }
        }
        else if (!playerInRange)
        {
            Debug.Log("out range");
            //dialogBox.SetActive(false);
        }
        

    }

}
