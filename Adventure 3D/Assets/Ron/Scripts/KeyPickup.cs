using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public bool Key;
    public GameObject Door;
    public GameObject key2;
    public Light keylight;
    public Color32 lightcolor;

    private void OnTriggerEnter(Collider other)
    {
        Keypickedup();
    }


    void Keypickedup()
    {
        Key = true;
        keylight.color = lightcolor;
        key2.SetActive(false);
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
