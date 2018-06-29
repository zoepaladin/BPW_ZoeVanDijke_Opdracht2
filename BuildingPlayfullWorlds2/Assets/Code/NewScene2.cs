using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewScene2 : MonoBehaviour
{

    IEnumerator Loadgame2()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(3);
    }

}
