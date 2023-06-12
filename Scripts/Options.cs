using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{
    public GameObject mainMenuUI;
    public GameObject levelSelectorUI;

    public void levelSelect()
    {
        levelSelectorUI.SetActive(true);
        mainMenuUI.SetActive(false);    
    }
}
