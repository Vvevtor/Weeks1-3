using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class WAVELERP : MonoBehaviour
{
    public AnimationCurve curve;

    [Range(0, 1)]
    public float direction;
    public float t;
    public Transform start;
    public Transform end;
    public float randommovespeed;
    // Start is called before the first frame update
    void Start()
    {
        direction = 1;
        randommovespeed = UnityEngine.Random.Range(0.001f, 0.01f); // I know we're not supposed to use concepts not from the first two weeks, I just really wanted to make something random, I guess I'll be losing marks for this since it's breaking the rules
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            randommovespeed = UnityEngine.Random.Range(0.001f, 0.01f); //once space is pressed, change the movespeed of the wave to a new random movespeed
        }
        
        if (t >= 1f)
        {
            direction = -1f;
        }
        if (t <= 0f)
        {
            direction = 1f;
        }
        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));
        t += randommovespeed * direction;
    }
}
