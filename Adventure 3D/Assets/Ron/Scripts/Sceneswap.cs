using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneswap : MonoBehaviour
{
    public string Scene;
    private void OnMouseDown()
    {
        SceneManager.LoadScene(Scene);
    }
}
