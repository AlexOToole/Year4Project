using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonTriggerL1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Button"))
        {
            //DO SOMETHING
            SceneManager.LoadScene("Level1");
            Debug.Log("Pressed");
        }
    }
}