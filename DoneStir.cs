using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// Legacy check for the stir scene for the exomorph has been changed
/// </summary>
public class DoneStir : MonoBehaviour
{

    public GameObject gameobject1;
    private void update()
    {
        if (gameobject1.transform.rotation.z > 150)
        {
            SceneManager.LoadScene("cut");
        }
    }
}

