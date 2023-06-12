using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerUI : MonoBehaviour
{
    public GameObject levelPassedUI;
    public GameObject levelFailedUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void levelPassed()
    {
        levelPassedUI.SetActive(true);
    }

    public void levelFailed()
    {
        levelFailedUI.SetActive(true);   
    }
}


