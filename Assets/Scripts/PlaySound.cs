using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLaySound : MonoBehaviour
{
    //Audiosource.
    public AudioSource audiosource;
    //Subscribes to audiosource.
    public void OnEnable()
    {
        Actions.Spotlight += PlaySound;
    }
    //Unsubscribes from audio source.
    public void OnDisable()
    {
        Actions.Spotlight -= PlaySound;
    }

    //Plays AudioSource.
    void PlaySound()
    {
        audiosource.Play();
    }
}
