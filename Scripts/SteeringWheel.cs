using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SteeringWheel : MonoBehaviour, IDragHandler, IPointerDownHandler,IPointerUpHandler
{
    private bool WheelBeingHeld = false;
    public RectTransform Wheel;
    private float WheelAngle = 0f;
    private float LastWheelAngle = 0f;
    private Vector2 center;
    public float MaxSteerAngle = 200f;
    public float ReleaseSpeed = 300f;
    public float OutPut;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!WheelBeingHeld && WheelAngle != 0)
        {
            float DeltaAngle = ReleaseSpeed *Time.deltaTime;
            if (Mathf.Abs(DeltaAngle) > Mathf.Abs(WheelAngle))
                WheelAngle = 0f;
            else if (WheelAngle > 0f)
                WheelAngle -= DeltaAngle;
            else
                WheelAngle += DeltaAngle;
        }
        Wheel.localEulerAngles = new Vector3(0, 0, -WheelAngle);
        OutPut = WheelAngle / MaxSteerAngle;
    }

    public void OnPointerDown(PointerEventData data)
    {
        WheelBeingHeld = true;
        center = RectTransformUtility.WorldToScreenPoint(data.pressEventCamera, Wheel.position);
        LastWheelAngle = Vector2.Angle(Vector2.up, data.position - center);
    }

    public void OnDrag(PointerEventData data)
    {
        float NewAngle = Vector2.Angle(Vector2.up, data.position - center);
        if ((data.position - center).sqrMagnitude >= 400)
        {
            if (data.position.x > center.x)
                WheelAngle += NewAngle - LastWheelAngle;
            else
                WheelAngle -= NewAngle - LastWheelAngle;
        }
        WheelAngle = Mathf.Clamp(WheelAngle, -MaxSteerAngle, MaxSteerAngle);
        LastWheelAngle = NewAngle;
    }

    public void OnPointerUp(PointerEventData data)
    {
        OnDrag(data);
        WheelBeingHeld = false;
    }
}
