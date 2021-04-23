using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToNormalArea : MonoBehaviour
{
    public AllowArea area;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
            area.GoBack();
    }
}
