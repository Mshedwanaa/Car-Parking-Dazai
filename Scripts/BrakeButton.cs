using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BrakeButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public CarController carController;

    public void OnPointerDown(PointerEventData eventData)
    {
        carController.isBrakePressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        carController.isBrakePressed = false;
    }



}
