using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingHandler : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            TeleportManager.instance.MovePlayerPosition(0);
    }
}
