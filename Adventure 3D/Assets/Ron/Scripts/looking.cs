using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class looking : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, Input.GetAxisRaw("Horizontal"), 0);
    }
}
