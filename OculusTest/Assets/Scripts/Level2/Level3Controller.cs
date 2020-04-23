using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level3Controller : MonoBehaviour
{
    public bool startLevel3 = false;
    public GameObject ball;
    public GameObject temp;
    public Text scoreText;
    public Text timerText;
    int basketsMade = 0;
    public float targetTime = 30.0f;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Points: \n 0";
    }

    // Update is called once per frame
    void Update()
    {
        if (startLevel3)
        {
            scoreText.text = "Points: \n" + basketsMade.ToString();
            timerText.text = targetTime.ToString();
            if (targetTime > 0)
            {
                targetTime -= Time.deltaTime;
                //targetTime = Mathf.Round(targetTime * 10.0f) * 0.1f;
            }
            if (targetTime < 0)
            {
                scoreText.text = "Points: \n" + basketsMade.ToString();
                timerText.text = "GameOver";
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            if (startLevel3)
            {
                if (targetTime > 0)
                {
                    basketsMade++;
                    Instantiate(ball, new Vector3(-0.288f, 0.95f, 0), Quaternion.identity);
                    //Might not need this due to the level floor collider script.
                    temp = collision.gameObject;
                    temp.GetComponent<Baskeball>().destroy = true;
                }
            }
        }
    }
}