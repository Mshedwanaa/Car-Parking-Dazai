using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    private Rigidbody targetRB;
    public float speed;
    public Vector3 offset;

    void Start()
    {
        targetRB = target.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 targetForward = (targetRB.velocity + target.transform.forward).normalized;
        transform.position = Vector3.Lerp(transform.position,
        target.position + target.transform.TransformVector(offset)
        + targetForward * (-5f),
        speed * Time.deltaTime);
        transform.LookAt(target);
    }
}
