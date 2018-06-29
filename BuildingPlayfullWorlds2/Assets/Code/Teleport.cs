using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject ui;
    public GameObject objToTeleport;
    public Transform TelLocation;
    public AudioClip sound;
    AudioSource audio;
    public bool alreadyPlayed = false;


    // Use this for initialization
    void Start ()
    {
        audio = GetComponent<AudioSource>();
        ui.SetActive(false);
	}

    void OnTriggerStay(Collider other)
    {
        ui.SetActive(true);
        if ((other.gameObject.tag == "Player") && Input.GetKeyDown(KeyCode.E))
        {
            if (!alreadyPlayed)
            {
                audio.PlayOneShot(sound);
                alreadyPlayed = true;
            }

            objToTeleport.transform.position = TelLocation.transform.position;
        }

    }

    void OnTriggerExit()
    {
        ui.SetActive(false);
    }

}
