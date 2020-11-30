using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateVelocity : MonoBehaviour
{
    private Vector3 vel;
    public FloatValue velocity;

    private Vector3 _prevPosition;

    void Update()
    {
        vel = (transform.position - _prevPosition) / Time.deltaTime;
        _prevPosition = transform.position;

        velocity.@float = vel.y;
        Debug.Log(velocity.@float);
    }


}
