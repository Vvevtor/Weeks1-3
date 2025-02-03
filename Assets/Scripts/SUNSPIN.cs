using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SUNSPIN : MonoBehaviour
{
    public float spinSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            spinSpeed += 0.1f; //leftmouse click adds 1 speed to rotation
        }

        if (Input.GetMouseButtonDown(1))
        {
            spinSpeed += -0.1f; //rightmouse click removes 1 speed from the rotation
        }

        Vector3 spinny = transform.eulerAngles; //spinning code I did for a coding gym, hope I don't get marks off for using it, it rotates and object in place, since the rays are tethered to the circle they spin with it
        spinny.z += spinSpeed;
        transform.eulerAngles = spinny;
    }
}
