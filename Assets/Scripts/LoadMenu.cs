using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadMenu : MonoBehaviour
{

    // Use this for initialization
    public void BackToMenu()
    {
        if (Input.GetKeyDown("Cancel"))
        {
            SceneManager.LoadScene("gta7_mainmenu");
            print("space key was pressed");
        }
    }
}
