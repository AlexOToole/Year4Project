using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3BoxScript : MonoBehaviour
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
       // if (collision.gameObject.tag == collision.gameObject.GetComponent<ShapeScript>().color + "Cube")
        //{
            //if its not still being grabbed.
            if (!collision.gameObject.GetComponent<OVRGrabbable>().isGrabbed)
            {
                //if its not aleady in the box --> stops the same cube being added many times in the one go
                if (!collision.gameObject.GetComponent<ShapeScript>().inBox)
                {
                    gameController.GetComponent<FinalLevelController>().inputOrder.Add(collision.gameObject.GetComponent<ShapeScript>().color + " " + collision.gameObject.GetComponent<ShapeScript>().shape);
                    //Gets the cubes index in the inputOrder list.
                    collision.gameObject.GetComponent<ShapeScript>().index = gameController.GetComponent<FinalLevelController>().inputOrder.Count - 1;
                    collision.gameObject.GetComponent<ShapeScript>().inBox = true;
                }
            }
       // }
        Debug.Log(gameController.GetComponent<FinalLevelController>().inputOrder.Count);
    }
}
