using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class fanscontroller : MonoBehaviour
{
    public FloatValue velocity;
    public SerialPort serial = new SerialPort("COM5", 9600);
    private bool lightState = false;

    private bool fanIsOn = false;
    void Start()
    {
  
    }

    void Update()
    {

        CheckVelocity();
    }

    private void CheckVelocity()
    {
        if (velocity.@float > 0 && !fanIsOn)
        {            
            onLed();
            Debug.Log("velocity > 0");
            fanIsOn = true;
        }
        if(velocity.@float < 0 && fanIsOn)
        {
            offLed();
            Debug.Log("velocity < 0");
            fanIsOn = false;
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
        Debug.Log("moet nu waaien");
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