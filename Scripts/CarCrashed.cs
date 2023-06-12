using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarCrashed : MonoBehaviour
{
    public GameManagerUI failed;

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        print("Car crashed");
        //SceneManager.LoadScene("level failed");
        failed.levelFailed();
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}


