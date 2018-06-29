using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window : MonoBehaviour
{
    public GameObject uiGood;
    public GameObject uiGone;
    public AudioClip sound;
    AudioSource audio;
    public bool alreadyPlayed = false;


    // Use this for initialization
    void Start ()
    {
        audio = GetComponent<AudioSource>();
        uiGood.SetActive(false);
    }

    void OnTriggerStay(Collider other)
    {
        if ((other.gameObject.tag == "PickUp"))
        {
            if (!alreadyPlayed)
            {
                audio.PlayOneShot(sound);
                alreadyPlayed = true;
            }

            uiGood.SetActive(true);
            uiGone.SetActive(false);
        }

    }

}
