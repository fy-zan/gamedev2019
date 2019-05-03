using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HailOff : MonoBehaviour
{

    [SerializeField]
    ParticleSystem Hail;
    // Start is called before the first frame update
    void Start()
    {
        Hail.Pause();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        Hail.Stop();
    }
}
