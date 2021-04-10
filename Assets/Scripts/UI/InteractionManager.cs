using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    public static InteractionManager instance;
    public GameObject InteractButton;
    private bool interaction=false;
    private int whereToGo = 0;
    private void Awake()
    {
        instance=this;
    }
    void Start()
    {
        InteractButton.SetActive(false);
    }

    public void InteractSet(bool set,int lvl)
    {
        whereToGo = lvl;
        interaction = set;
        InteractButton.SetActive(set);
    }

    public void ButtonPressed()
    {
        TeleportManager.instance.MovePlayerPosition(whereToGo);
        
    }

    private void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            if (interaction)
                ButtonPressed();
        }
    }
}
