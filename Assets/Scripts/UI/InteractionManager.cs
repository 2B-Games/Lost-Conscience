using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    public static InteractionManager instance;
    public GameObject InteractButton;
    public GameObject magicBox;
    public GameObject handMagicBox;
    public GameObject GTFO;
    private bool interaction=false;
    private int whereToGo = 0;
    private bool isHidden = false;
    bool isGameFinish = false;
    private void Awake()
    {
        instance=this;
    }
    void Start()
    {
        InteractButton.SetActive(false);
        GTFO.SetActive(false);
    }

    public void HideUi(bool set)
    {
        
            InteractButton.SetActive(false);
            isHidden = set;
    }

    public void InteractSet(bool set,int lvl)
    {
        if (!isHidden && !isGameFinish)
        {
            whereToGo = lvl;
            interaction = set;
            InteractButton.SetActive(set);
        }
    }

    public void ButtonPressed()
    {
        if(whereToGo==2)
        {
            magicBox.SetActive(true);
            handMagicBox.SetActive(false);
            isGameFinish = true;
            HideUi(true);
            StartCoroutine(EndGame());
        }
        else

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


    IEnumerator EndGame()
    {
        yield return new WaitForSeconds(2);
        GTFO.SetActive(true);
    }
}
