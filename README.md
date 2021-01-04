# Motion Trampoline

Unity workfile working with Kinect to create a jumping experience for Motion.

## Installation

Download ```MotionTrampoline``` folder and open with Unity version 2020.1.3f1.

## Usage

Put any joint name in the List in BodySourceView.cs script for the Kinect to track:

```C#
    private List<Kinect.JointType> _joints = new List<Kinect.JointType>
    {
        Kinect.JointType.HandLeft,
        Kinect.JointType.HandRight,
        Kinect.JointType.Head,
    };
```

This scripts finds the coordinates the BodySourceView script generates. In this case the head's coordinates are used for the height of the camera.
```C#
    public float coordinate;

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
        }
    }
```

## Contributing
Thomas Dwarshuis (Kinect connection and code)

Dimitri van Iersel (Arduino connection and audio)
