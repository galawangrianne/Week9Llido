using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    public float speed;


    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0); 
         // transform.Rotate function rotates an object around any axis
         // We will rorate the object around y-axis at "speed" degree per second
    }
}
