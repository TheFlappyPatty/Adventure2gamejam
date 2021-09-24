using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class THECHALIS : MonoBehaviour
{
    public bool CHALISPICKUP;
    public GameObject exit;
    public GameObject chalis;
    public string credits;
    public GameObject trap1;
    public GameObject trap2;
    public GameObject trap3;
    public GameObject trap4;
    public GameObject audio2;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == ("CHALIS"))
        {
            CHALISPICKUP = true;
            chalis.SetActive(false);
            trap1.SetActive(true);
            trap2.SetActive(true);
            trap3.SetActive(true);
            trap4.SetActive(true);
            exit.SetActive(true);
            audio2.SetActive(true);
        }
        if (collision.collider.tag == ("EXIT"))
        {
            if (CHALISPICKUP == true)
            {
                SceneManager.LoadScene(credits);
                Debug.Log("LOADWORLD CRITICAL FAILURE");
            }
        }
    }
}
