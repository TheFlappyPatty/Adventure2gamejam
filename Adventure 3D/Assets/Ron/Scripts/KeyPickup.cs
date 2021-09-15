using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public bool Key;
    public GameObject Door;

    private void OnTriggerEnter(Collider other)
    {
        Keypickedup();
    }


    void Keypickedup()
    {
        Key = true;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == ("door"))
        {
            if (Key == true)
            {
                Door.SetActive(false);
            }
        }
    }
}
