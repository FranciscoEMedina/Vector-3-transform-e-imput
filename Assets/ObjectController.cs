using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    
   // public Vector3 movementeVector;
    public float movementSpeed;
    public float movementSpeed2;
    public float movementSpeed3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
       {
            transform.position += new Vector3(movementSpeed,0,0);
       }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(movementSpeed, 0, 0);
        }

         if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3 (0,movementSpeed2,0);
        }

         if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, movementSpeed2, 0);
        }

         if (Input.GetKey(KeyCode.Z))
        {
            transform.position += new Vector3(0,0, movementSpeed3);
        }

        if (Input.GetKey(KeyCode.X))
        {
            transform.position -= new Vector3(0,0, movementSpeed3);
        }
    }
}
