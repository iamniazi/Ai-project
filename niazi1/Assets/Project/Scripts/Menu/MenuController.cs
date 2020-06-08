using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    void Awake()
    {
        // To show cursor after First Person Controller
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void Level_1 () {
		SceneManager.LoadScene ("level1");
	}

    public void Level_2()
    {
        SceneManager.LoadScene("b");
    }

    public void Level_3()
    {
        SceneManager.LoadScene("Level1");
    }
}
