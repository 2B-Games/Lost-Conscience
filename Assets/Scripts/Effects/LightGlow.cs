using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightGlow : MonoBehaviour
{
    Light myLight;
    void Start()
    {
        myLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        myLight.intensity = Mathf.PingPong(Time.time, 2);
    }
}
