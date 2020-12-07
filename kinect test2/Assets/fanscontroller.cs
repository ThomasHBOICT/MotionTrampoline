using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class fanscontroller : MonoBehaviour
{
    public FloatValue velocity;
    public SerialPort serial = new SerialPort("COM7", 9600);
    private bool lightState = false;

    void Start()
    {
    }

    void Update()
    {
        CheckVelocity();
    }

    private void CheckVelocity()
    {
        if (velocity.@float > 0)
        {
            onLed();
        }
        else
        {
            offLed();
        }
    }

    public void onLed()
    {
        if (serial.IsOpen == false)
        {
            serial.Open();
        }

        serial.Write("70");
        lightState = true;
    }

    public void offLed()
    {
        if (serial.IsOpen == false)
        {
            serial.Open();
        }

        serial.Write("5");
        lightState = false;
    }
}