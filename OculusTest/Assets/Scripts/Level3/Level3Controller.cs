using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level3Controller : MonoBehaviour
{
    public GameObject ball;
    public GameObject temp;
    public Text scoreText;
    int basketsMade = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Points: \n 0";
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Points: \n" + basketsMade.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            basketsMade++;
            Instantiate(ball, new Vector3(-0.288f, 0.95f, 0), Quaternion.identity);
            temp = collision.gameObject;
            temp.GetComponent<Baskeball>().destroy = true;
        }
    }
}