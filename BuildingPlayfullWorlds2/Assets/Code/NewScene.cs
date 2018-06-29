using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewScene : MonoBehaviour
{

	IEnumerator Loadgame ()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
	}

}
