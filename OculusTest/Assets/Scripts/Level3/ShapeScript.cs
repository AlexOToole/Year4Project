using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeScript : MonoBehaviour
{
    // Start is called before the first frame update
    public string shape;
    public string color;
    public bool inBox = false;
    public int index = -1;
    public Material[] possibleColours;
    public GameObject[] spawnPoints;
    GameObject gameController;
    int num;
    int point;
    float timer = 3.0f;
    bool search = true;
    void Start()
    {
        num = Random.Range(0, possibleColours.Length);
        gameController = GameObject.FindWithTag("GameController");
        gameObject.GetComponent<MeshRenderer>().material = possibleColours[num];
        shape = gameObject.name;
        color = possibleColours[num].name;
        //This loop places the shapes in at one of the spawn points then deactivates it so that no objects can be in the same spot.
        while (search)
        {
            point = Random.Range(0, spawnPoints.Length);
            if (spawnPoints[point].activeSelf)
            {
                gameObject.GetComponent<Transform>().position = spawnPoints[point].GetComponent<Transform>().position;
                spawnPoints[point].SetActive(false);
                search = false;
            }
        }
        gameController.GetComponent<FinalLevelController>().colourAt.Insert(gameController.GetComponent<FinalLevelController>().colorSize, color + " " + shape);
        gameController.GetComponent<FinalLevelController>().colorSize++;
    }

    // Update is called once per frame
    void Update()
    {
        if (inBox)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }

            if (timer <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
