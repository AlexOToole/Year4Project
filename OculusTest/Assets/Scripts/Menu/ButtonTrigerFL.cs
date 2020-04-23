using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonTrigerFL : MonoBehaviour
{
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Button"))
        {
            //DO SOMETHING
            SceneManager.LoadScene("Level3");
            Debug.Log("Pressed");
        }
    }
}
