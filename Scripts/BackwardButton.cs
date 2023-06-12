using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BackwardButton : MonoBehaviour,IPointerDownHandler, IPointerUpHandler 
{
    public CarController carController;

    public void OnPointerDown(PointerEventData eventData)
    {
        carController.isBackwardButtonPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        carController.isBackwardButtonPressed = false;
    }

}
