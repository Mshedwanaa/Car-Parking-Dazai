using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour 

{
    public int level;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OpenScene()
    {
        SceneManager.LoadScene("level " + level.ToString());
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Main menu");
    }
    public void Back()
    {
        SceneManager.LoadScene("Main menu");
    }
}
