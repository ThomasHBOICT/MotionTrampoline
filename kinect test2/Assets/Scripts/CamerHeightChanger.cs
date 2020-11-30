using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerHeightChanger : MonoBehaviour
{
    public FloatValue coords;
    public float offset;
    public float multiplier;

    private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = startPos + new Vector3(0, coords.@float * multiplier + offset, 0);
    }
}
