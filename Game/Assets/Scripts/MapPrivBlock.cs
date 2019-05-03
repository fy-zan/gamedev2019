using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapPrivBlock : Objects
{


    public int privAccess;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }




    public void OnTriggerEnter2D(Collider2D other)
    {

        GameObject player = GameObject.FindWithTag("Player");
        if (other.CompareTag("Player") && player.GetComponent<PlayerAttributes>().priv != privAccess)
        {
            Debug.Log(gameObject.name);
            gameObject.GetComponent<PolygonCollider2D>().enabled = true;
            if (!dialogBox.activeInHierarchy)
            {
                dialogText.text = dialog;
                dialogBox.SetActive(true);
            }

        }
    }

     
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            gameObject.GetComponent<PolygonCollider2D>().enabled = false;
            dialogBox.SetActive(false);
        }

    }
}

