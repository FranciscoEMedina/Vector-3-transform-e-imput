using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
        public GameObject myCube;
        public Vector3 movementeVector;
    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        if (myCube.transform.position.x <8)
        {
            myCube.transform.position += movementeVector;
        }
    }
}
