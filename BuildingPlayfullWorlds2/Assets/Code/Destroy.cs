using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public AudioClip sound;
    AudioSource audio;
    public bool alreadyPlayed = false;
    public GameObject uiEnd;
    public GameObject uiDestroy;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        uiEnd.SetActive(false);
        uiDestroy.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hitInfo;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hitInfo))
            {
                BoxCollider bc = hitInfo.collider as BoxCollider;
                if (bc != null)
                {
                    if (!alreadyPlayed)
                    {
                        audio.PlayOneShot(sound);
                        alreadyPlayed = true;
                    }
                    Destroy(bc.gameObject);
                    uiEnd.SetActive(true);
                    uiDestroy.SetActive(false);
                }
            }

        }
    }

}
