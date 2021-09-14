using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody playedbody;
    public CharacterController player;
    public int movementspeed;
    void Update()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
           playedbody.AddForce(Vector3.forward);
          
        }
        if (Input.GetKey(KeyCode.S))
        {
            playedbody.AddForce(Vector3.back);

        }
        if (Input.GetKey(KeyCode.A))
        {
            playedbody.AddForce(Vector3.left);

        }
        if (Input.GetKey(KeyCode.D))
        {
            playedbody.AddForce(Vector3.right);

        }
    }
}
