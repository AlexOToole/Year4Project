using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public string Name;
    GameObject gameController;

    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.FindWithTag("GameController");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Function that adds the cube that enters the box to the list of cubes in the box.
    //Currently cannot change your mind(Once cube is in a box it must stay.
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == collision.gameObject.GetComponent<Cube>().color + "Cube")
        {
            //if its not still being grabbed.
            if (!collision.gameObject.GetComponent<OVRGrabbable>().isGrabbed)
            {
                //if its not aleady in the box --> stops the same cube being added many times in the one go
                if (!collision.gameObject.GetComponent<Cube>().inBox)
                {
                    gameController.GetComponent<Controller>().inputOrder.Add(collision.gameObject.GetComponent<Cube>().color);
                    //Gets the cubes index in the inputOrder list.
                    collision.gameObject.GetComponent<Cube>().index = gameController.GetComponent<Controller>().inputOrder.Count - 1;
                    collision.gameObject.GetComponent<Cube>().inBox = true;
                }
            }
        }
        Debug.Log(gameController.GetComponent<Controller>().inputOrder.Count);
    }
}
