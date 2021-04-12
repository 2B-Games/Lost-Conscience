using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    public static InteractionManager instance;
    public GameObject InteractButton;
    private bool interaction=false;
    private int whereToGo = 0;
    private bool isHidden = false;
    private void Awake()
    {
        instance=this;
    }
    void Start()
    {
        InteractButton.SetActive(false);
    }

    public void HideUi(bool set)
    {
        InteractButton.SetActive(false);
        isHidden = set;
    }

    public void InteractSet(bool set,int lvl)
    {
        if (!isHidden)
        {
            whereToGo = lvl;
            interaction = set;
            InteractButton.SetActive(set);
        }
    }

    public void ButtonPressed()
    {
        TeleportManager.instance.MovePlayerPosition(whereToGo);
        
    }

    private void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            if (interaction && !isHidden)
                ButtonPressed();
        }
    }
}
