using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarParked : MonoBehaviour
{

    public GameManagerUI passed;


    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        print("Car  Parked Successfully");
        passed.levelPassed();

    }   
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
