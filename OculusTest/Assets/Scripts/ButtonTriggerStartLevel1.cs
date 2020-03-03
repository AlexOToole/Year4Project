using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ButtonTriggerStartLevel1 : MonoBehaviour
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
            gameController.GetComponent<Controller>().startLevel1 = true;
            
            Debug.Log("Pressed");
        }
    }
}
