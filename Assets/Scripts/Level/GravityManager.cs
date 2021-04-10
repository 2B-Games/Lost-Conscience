using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityManager : MonoBehaviour
{
    public static GravityManager instance;
    public Vector3 gravityNormal;
    public Vector3 gravityEscuela;

    public Quaternion newRotation;

    private GameObject PlayerObj;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        Player p = (Player)FindObjectOfType(typeof(Player));
        PlayerObj = p.gameObject;
        GoToNormal();
    }
    public void GoToNormal()
    {
        PlayerObj.transform.localRotation = Quaternion.identity;
        Physics.gravity = gravityNormal;
    }
    public void EnterToEscuela()
    {
        PlayerObj.transform.localRotation = newRotation;
        Physics.gravity = gravityEscuela;
    }
   
}
