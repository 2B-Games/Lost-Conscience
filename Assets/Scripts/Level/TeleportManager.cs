using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportManager : MonoBehaviour
{
    public static TeleportManager instance;

    public Transform[] spawnPosition;
    private void Awake()
    {
        instance = this;
    }

    public void MovePlayerPosition(int pos)
    {
        Player player = (Player)FindObjectOfType(typeof(Player));
      
        player.gameObject.transform.position = spawnPosition[pos].position;
    }
}
