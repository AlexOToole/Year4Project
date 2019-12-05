using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//3 box script
// each with access to game controller script
//
// box script = 
// check collision object index with colourAt to make sure the object colour matches box colour
// if correct add that cube to a order list.
// repeat 
// when order list length is equal to shape length check it against a correct order list to make sure the cubes were but in each box in the correct order.

public class Controller : MonoBehaviour
{
    public GameObject[] shapes;
    public static string[] colourAt;
    public static string[] inputOrder;
    public static string[] correctOrder = { "Red", "Blue", "Blue", "Green", "Green", "Red" };
    // Start is called before the first frame update
    void Start()
    {
        //Colour od the shapes in order from left to right.
        colourAt[0] = "Red";
        colourAt[1] = "Green";
        colourAt[2] = "Green";
        colourAt[3] = "Blue";
        colourAt[4] = "Red";
        colourAt[5] = "Blue";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
