using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int movementspeed  = 5;
    public int sensitivity = 2;
    public GameObject camara;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward  * movementspeed * Time.deltaTime);  a
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * movementspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * movementspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * movementspeed * Time.deltaTime);
        }



        transform.transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivity, 0);
       

    }
}
