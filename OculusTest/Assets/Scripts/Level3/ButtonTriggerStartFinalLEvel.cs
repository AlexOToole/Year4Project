using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTriggerStartFinalLEvel : MonoBehaviour
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
            gameController.GetComponent<FinalLevelController>().startLevel3 = true;

            Debug.Log("Pressed");
        }
    }
}
