using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animCur : MonoBehaviour
{
    public AnimationCurve curve;

    [Range(0, 3)]
    public float t;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

        if(t > 3)
        {
            t = 0;
        }

        transform.localScale = Vector2.one * curve.Evaluate(t);
    }
}
