using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportManager : MonoBehaviour
{
    public static TeleportManager instance;

    public Transform[] spawnPosition;
    private TeleportEffect effect;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        effect = GetComponent<TeleportEffect>();
    }
    public void MovePlayerPosition(int pos)
    {
        StartCoroutine(EffectSteps(pos));
    }


    IEnumerator EffectSteps(int pos)
    {
        Player player = (Player)FindObjectOfType(typeof(Player));
        effect.StartEffect();
        InteractionManager.instance.HideUi(true);
        player.ActivateSound(false);
        yield return new WaitForSeconds(2);
        effect.BackToNormal();
        InteractionManager.instance.HideUi(false);
        player.gameObject.transform.position = spawnPosition[pos].position;
        player.ActivateSound(true);
        yield return new WaitForSeconds(2);
        effect.Finish();
    }
}
