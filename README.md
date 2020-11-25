# Motion Trampoline

Unity workfile working with Kinect to create a jumping experience for Motion.

## Installation

Download the workfile and open with Unity version 2020.1.3f1.

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

For finding the coordinates of the head (or any other joint) from the Kinect in CoordinateFinder.cs script:
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
Thomas Dwarshuis
