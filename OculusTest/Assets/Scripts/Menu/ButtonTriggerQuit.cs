using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonTriggerQuit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Button"))
        {
            //DO SOMETHING
            Application.Quit();
            Debug.Log("Pressed");
        }
    }
}