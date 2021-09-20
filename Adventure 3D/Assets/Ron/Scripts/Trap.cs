using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    private bool inout;
    public bool x;
    private float zposition;
    private float xposition;
    public float crossdistanceZ;
    public float crossdistanceX;
    private float zstart;
    private float xstart;
    public float speed;
    public GameObject respawnpoint;
    public GameObject player;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            playerdied();
        }
    }
    void playerdied()
    {
        player.transform.position = new Vector3(respawnpoint.transform.localPosition.x, respawnpoint.transform.localPosition.y, respawnpoint.transform.localPosition.z);
        Debug.Log("working");
    }

    public void Update()
    {
        if (x == false)
        {
            if (gameObject.transform.localPosition.z >= zposition)
            {
                inout = true;
            }
            if (gameObject.transform.localPosition.z <= zstart)
            {
                inout = false;
            }
            if (inout == true)
            {
                gameObject.transform.Translate(0, 0, -speed * Time.deltaTime);
            }
            if (inout == false)
            {
                gameObject.transform.Translate(0, 0, speed * Time.deltaTime);
            }
        }
        if (x == true)
        {
            if (gameObject.transform.localPosition.x >= xposition)
            {
                inout = true;
            }
            if (gameObject.transform.localPosition.x <= xstart)
            {
                inout = false;
            }
            if (inout == true)
            {
                gameObject.transform.Translate(-speed * Time.deltaTime, 0, 0);
            }
            if (inout == false)
            {
                gameObject.transform.Translate(speed * Time.deltaTime, 0, 0);
            }
        }
    }
    private void Start()
    {
        zposition = gameObject.transform.position.z + crossdistanceZ;
        xposition = gameObject.transform.position.x + crossdistanceX;
        xstart = gameObject.transform.position.x;
        zstart = gameObject.transform.position.z;
    }
}
