using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour {
    IEnumerator LoadGame()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(1);
    }
}
