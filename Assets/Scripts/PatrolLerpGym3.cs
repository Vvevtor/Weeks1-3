using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolLerpGym3 : MonoBehaviour
{

    public AnimationCurve curve;

    [Range(0, 1)]
    public float t;
    public Transform start;
    public Transform end;
    public bool Right = true;
    public float move = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Right)
        {
            t += move;
        }
        else
        {
            t += -move;
        }
        
        if (t >= 1f)
        {
            Right = false;
        }

        if (t <= 0f)
        {
            Right = true;
        }
        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));
    }
}
