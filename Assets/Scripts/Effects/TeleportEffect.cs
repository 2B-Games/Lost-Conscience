using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportEffect : MonoBehaviour
{
    public Animator blackScreenAnimation;
    float basicFieldOfView;
    Camera cam;
    bool goCrazy = false;
    bool isActivate = false;
    private void Start()
    {
        cam = Camera.main;
        basicFieldOfView = 80;
    }
    public void StartEffect()
    {
        isActivate = true;
        goCrazy = true;
        blackScreenAnimation.SetTrigger("GoBlack");
    }
    public void BackToNormal()
    {
        goCrazy = false;
        blackScreenAnimation.SetTrigger("GoClean");
    }
    public void Finish()
    {
        goCrazy = false;
        isActivate = false;
        cam.fieldOfView = basicFieldOfView;
    }
    // Update is called once per frame
    void Update()
    {
        if (isActivate)
        {
            if (goCrazy)
                cam.fieldOfView += Time.deltaTime * 100;
            else
            {
                cam.fieldOfView -= Time.deltaTime * 100; 
                if (cam.fieldOfView <= basicFieldOfView)
                    cam.fieldOfView = basicFieldOfView;
            }
        }
    }
}
