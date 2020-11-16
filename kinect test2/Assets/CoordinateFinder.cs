using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoordinateFinder : MonoBehaviour
{
    public float coordinate;

    private GameObject head;
    // Start is called before the first frame update
    void Start()
    {
      
    }

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
        //Debug.Log(head.transform.position.x + "," + head.transform.position.y);
        }
    }
}
