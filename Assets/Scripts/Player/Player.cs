using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{

    Vector3 previusMovement;
    float movingTime = 0;
    AudioSource audioSource;
    bool isMakingSound = false;
    void Start()
    {
        TeleportManager.instance.MovePlayerPosition(0);
        audioSource = GetComponent<AudioSource>();
    }
    public void ActivateSound(bool set)
    {
        previusMovement = transform.position;
        isMakingSound = set;
        if (!set)
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.Stop();
        }
    }

    private void Update()
    {
        if (isMakingSound)
        {
            if (transform.position != previusMovement)
                movingTime = 0.2f;
            previusMovement = transform.position;
            movingTime -= Time.deltaTime;
            if (!audioSource.isPlaying && movingTime > 0)
            {
                audioSource.Play();
            }
            if (movingTime <= 0)
                audioSource.Stop();
        }
    }
}
