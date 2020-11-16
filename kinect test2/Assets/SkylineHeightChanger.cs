using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkylineHeightChanger : MonoBehaviour
{
    public Transform pos;
    public CoordinateFinder coords;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos.position = new Vector3(0, coords.coordinate *-1, 0);
    }
}
