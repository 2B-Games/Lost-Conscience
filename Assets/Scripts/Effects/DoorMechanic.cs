using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMechanic : MonoBehaviour
{
   public Collider[] wallsToDisable;
    private void Start()
    {
        DoTheThing(true);
    }
    void DoTheThing(bool set)
    {
        foreach(Collider c in wallsToDisable)
        {
            c.enabled = set;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
            DoTheThing(false);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            StartCoroutine(CloseDoors());
    }

    IEnumerator CloseDoors()
    {
        yield return new WaitForSeconds(2);
        DoTheThing(true);
    }
}
