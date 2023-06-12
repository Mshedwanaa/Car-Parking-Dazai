using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Options select;
    public void PlayGame()
    {
        select.levelSelect();
    }
    public void QuitGame()
    {
        Debug.Log("Quit game");
        Application.Quit();
    }


}


