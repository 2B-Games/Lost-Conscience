using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllowArea : MonoBehaviour
{
    public GameObject area;
    public GameObject[] disableObjets;
    public bool entering = true;
    void Start()
    {
        GoBack();
    }
    public void GoBack()
    {
        area.SetActive(false);
        foreach (GameObject go in disableObjets)
        {
            go.SetActive(true);
        }
    }
    void Allow()
    {
        area.SetActive(true);
        foreach(GameObject go in disableObjets)
        {
            go.SetActive(false);
        }
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if(entering)
                Allow();
            else
                GoBack();
        }
    }
    
}
