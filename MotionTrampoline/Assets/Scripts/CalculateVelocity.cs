using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateVelocity : MonoBehaviour
{
    public BodySourceView kinect;

    private Vector3 vel;
    public FloatValue velocity;

    private Vector3 _prevPosition;

    void Update()
    {
        if (kinect.bodyFound)
        {
        vel = (transform.position - _prevPosition) / Time.deltaTime;
        _prevPosition = transform.position;

        velocity.@float = vel.y;
        //Debug.Log(velocity.@float);
        }
    }


}
