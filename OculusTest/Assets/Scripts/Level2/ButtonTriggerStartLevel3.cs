using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ButtonTriggerStartLevel3 : MonoBehaviour
{

    GameObject gameController;
    private void Start()
    {
        gameController = GameObject.FindWithTag("Hoop");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Button"))
        {
            //DO SOMETHING
            gameController.GetComponent<Level3Controller>().startLevel3 = true;

            Debug.Log("Pressed");
        }
    }
}