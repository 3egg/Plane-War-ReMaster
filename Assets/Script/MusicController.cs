using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
     private AudioSource audioSource;

    private void Awake()
    {
        /*
        int length = FindObjectsOfType<MusicController>().Length;
        if (length > 1)
        {
            DestroyObject(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
*/

        audioSource = GetComponent<AudioSource>();
    }

    public void PlayOrStopMusic()
    {
        //audioSource.enabled = true; // I put this just in case.
        audioSource.Play(); // doesn't tell me that AudioSource is enabled anymore because of the previous line, but still does not play.
    }
}