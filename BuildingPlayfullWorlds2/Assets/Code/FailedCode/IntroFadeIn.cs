using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class IntroFadeIn : MonoBehaviour
{
    public Canvas eventCanvas;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "IntroCamera") 
        {
            eventCanvas.GetComponent<CanvasFadeIn>().setFadeIn();
            StartCoroutine(LoadGame());
        }
    }
    IEnumerator LoadGame()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(1);
    }
}
