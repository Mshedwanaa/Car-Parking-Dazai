using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ForwardButton : MonoBehaviour,IPointerDownHandler, IPointerUpHandler
{
    public CarController carController;

    public void OnPointerDown(PointerEventData eventData)
    {
        carController.isForwardButtonPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        carController.isForwardButtonPressed = false;
    }
}
