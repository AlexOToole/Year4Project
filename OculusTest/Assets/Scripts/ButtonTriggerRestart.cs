using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonTriggerRestart : MonoBehaviour
{
    GameObject gameController;
    private void Start()
    {
        gameController = GameObject.FindWithTag("GameController");
    }

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
