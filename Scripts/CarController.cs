using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public AudioSource audioSource;
    
    public WheelCollider FrontLeftWheel;
    public WheelCollider FrontRightWheel;
    public WheelCollider BackLeftWheel;
    public WheelCollider BackRightWheel;

    public Transform FrontLeftWheelTransform;
    public Transform FrontRightWheelTransform;
    public Transform BackLeftWheelTransform;
    public Transform BackRightWheelTransform;

    public float acceleration = 500f;
    public float breakingForce = 300f;
    public float maxTurnAngle = 15f;
    public float currentAcceleration = 0f;
    public float currentBreakingForce = 0f;
    private float currentTurnAngle = 0f;

    public SteeringWheel steeringWheel;
    public bool isForwardButtonPressed = false;
    public bool isBackwardButtonPressed = false;
    public bool isBrakePressed;

    public void Start()
    {
   
    }
    
    public void FixedUpdate()
    {
        float forwardInput = isForwardButtonPressed ? 1f : 0f;
        float backwardInput = isBackwardButtonPressed ? -1f : 0f;

        currentAcceleration = acceleration * (forwardInput + backwardInput);

        if (isBrakePressed) 
            currentBreakingForce = breakingForce;
        else
            currentBreakingForce = 0f;

        FrontRightWheel.motorTorque = currentAcceleration;
        FrontLeftWheel.motorTorque = currentAcceleration;

        FrontRightWheel.brakeTorque = currentBreakingForce;
        FrontLeftWheel.brakeTorque = currentBreakingForce;
        BackRightWheel.brakeTorque = currentBreakingForce;
        BackLeftWheel.brakeTorque = currentBreakingForce;

        currentTurnAngle = maxTurnAngle * steeringWheel.OutPut;
        FrontLeftWheel.steerAngle = currentTurnAngle;
        FrontRightWheel.steerAngle = currentTurnAngle;

        
        UpdateWheel(FrontRightWheel, FrontRightWheelTransform);
        UpdateWheel(FrontLeftWheel, FrontLeftWheelTransform);
        UpdateWheel(BackRightWheel, BackRightWheelTransform);
        UpdateWheel(BackLeftWheel, BackLeftWheelTransform);
    }


    public void OnCollisionEnter (Collision col)
    {
        if(col.gameObject.tag == "NPC cars")
        {
            audioSource.Play();
        }
    }



    void UpdateWheel(WheelCollider col, Transform trans)
    {

        
        Vector3 position;
        Quaternion rotation;
        col.GetWorldPose(out position, out rotation);
        trans.position = position;
        trans.rotation = rotation;
    }
}