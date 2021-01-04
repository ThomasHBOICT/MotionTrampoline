using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoordinateFinder : MonoBehaviour
{
    public float coordinate;
    public FloatValue height;

    private GameObject head;

    // Update is called once per frame
    void Update()
    {
        if (head == null)
        {
            head = GameObject.Find("Head");
        }
        if(head != null)
        {
            coordinate = head.transform.position.y;
            height.@float = coordinate;
        }
    }
}
