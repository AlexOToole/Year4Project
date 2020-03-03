using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public GameObject[] Boxs;
    public GameObject[] shapes;
    //public string[] colourAt;
    public List<string> inputOrder;
    public string[] correctOrder = { "Red", "Blue", "Blue", "Green", "Green", "Red" };
    bool correct = false;
    public float targetTime = 10.0f;
    public Text titleText;
    public Text orderText;
    public bool startLevel1 = false;
    // Start is called before the first frame update
    void Start()
    {
        //Colour of the shapes in order from left to right.
        //colourAt[0] = "Red";
        //colourAt[1] = "Green";
        //colourAt[2] = "Green";
        //colourAt[3] = "Blue";
        //colourAt[4] = "Red";
        //colourAt[5] = "Blue";
    }

    // Update is called once per frame
    void Update()
    {
        //Timer Code - stops once its less than 0;
        if (startLevel1)
        { 
            if (targetTime > 0)
            {
                targetTime -= Time.deltaTime;
            }

            if (targetTime <= 0)
            {
                titleText.gameObject.SetActive(false);
                orderText.text = "The correct order is \n";
                for (int i = 0; i < correctOrder.Length; i++)
                {
                    orderText.text += correctOrder[i] + "\n";
                }
                //When the input order list contains 6 entries, check the answer.
                if (inputOrder.Count == 6)
                {
                    checkAnswer();
                }
            }
            else
            {
                //targetTime = Mathf.Round(targetTime);
                orderText.text = targetTime.ToString();
            }

        }
        
    }

    void checkAnswer()
    {
        if (inputOrder.Count == 6)
        {
            for (int i = 0; i < correctOrder.Length; i++)
            {
                if (inputOrder[i] == correctOrder[i])
                {
                    correct = true;
                    orderText.text = "You win! Press the red button to restart.";
                }
                else
                {
                    correct = false;
                    orderText.text = "You lose! Press the red button to restart.";
                }
            }
        }
    }
}
