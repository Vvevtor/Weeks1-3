using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SUNLERP : MonoBehaviour
{

    public AnimationCurve curve;

    [Range(0, 1)]
    public float direction;
    public float t;
    public Transform start;
    public Transform end;
    // Start is called before the first frame update
    void Start()
    {
        direction = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (t >= 1f) //if the t value is greater than 1, reverse the direction
        {
            direction = -1f;
        }
        if (t <= 0f) //if the t value is lower than 0, reverse the direction
        {
            direction = 1f;
        }
        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));
        t += 0.001f * direction; //the transformation is updated each frame (more than once per frame in this case since I'm not using the proper time stuff), and multiplied by the direction number (basically reverse the animationcurve once it finishes)
    }
}
