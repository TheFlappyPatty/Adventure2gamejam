using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creditswaper : MonoBehaviour
{
    public GameObject creditactive;
    public GameObject Disablecreadit;
    private void OnMouseDown()
    {
        creditactive.SetActive(true);
        Disablecreadit.SetActive(false);
    }
}
