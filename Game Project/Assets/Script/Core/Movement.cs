using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Horror.Core
{
    public class Movement : MonoBehaviour
  {
     public float movementSpeed;

     void FixedUpdate()
    {
        if (Input.GetKey ("w") && !Input.GetKey ("s")) 
        {
            transform.position += transform.TransformDirection (Vector3.forward) * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey("s") && !Input.GetKey("w"))
        { 
            transform.position -= transform.TransformDirection (Vector3.forward) * Time.deltaTime * movementSpeed;
        }
        if (Input.GetKey("a") && !Input.GetKey("d"))
        {
            transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey("d") && !Input.GetKey("a"))
        {
            transform.position -= transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;
        }                 
    }
    
  }
}