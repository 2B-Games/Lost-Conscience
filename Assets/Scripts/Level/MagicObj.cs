using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicObj : MonoBehaviour
{
    public int DestinationLevel = 0;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            InteractionManager.instance.InteractSet(true, DestinationLevel);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            InteractionManager.instance.InteractSet(false,0);
        }
    }
}
