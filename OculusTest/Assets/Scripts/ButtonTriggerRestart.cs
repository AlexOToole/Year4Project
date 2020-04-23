using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonTriggerRestart : MonoBehaviour
{
    GameObject gameController;
    public string Level;
    private void Start()
    {
        gameController = GameObject.FindWithTag("GameController");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Button"))
        {
            //DO SOMETHING
            SceneManager.LoadScene(Level);
            Debug.Log("Pressed");
        }
    }
}
