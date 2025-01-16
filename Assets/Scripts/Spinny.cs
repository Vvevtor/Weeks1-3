using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinny : MonoBehaviour
{
    public float spinSpeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 spinny = transform.eulerAngles;
        spinny.z += spinSpeed;
        transform.eulerAngles = spinny;
    }
}
