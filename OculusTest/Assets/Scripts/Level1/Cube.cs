﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    GameObject gameController;
    public string color;
    public Material Grey;
    Material startMaterial;
    public bool inBox = false;
    public int index = -1;
    public GameObject[] spawnPoints;
    bool search = true;
    int point;
    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.FindWithTag("GameController");
        startMaterial = gameObject.GetComponent<MeshRenderer>().material;
        RemoveMaterial();
        //Loop that randomly places the cubes on the desk so that they are not 
        //in the same order every time.
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
    }

    // Update is called once per frame
    void Update()
    {
        if (gameController.GetComponent<Controller>().startLevel1)
        {
            if (gameController.GetComponent<Controller>().targetTime > 0.0f)
            {
                gameObject.GetComponent<OVRGrabbable>().enabled = false;
                ResetMaterial();
            }
            else
            {
                gameObject.GetComponent<OVRGrabbable>().enabled = true;
                RemoveMaterial();
            }

            //Adds the colours back once all the boxes are full.
            if (gameController.GetComponent<Controller>().inputOrder.Count >= 6)
            {
                ResetMaterial();
            }
        }
    }

    //Function that changes the cube material to a grey one.
    public void RemoveMaterial()
    {
        gameObject.GetComponent<MeshRenderer>().material = Grey;
    }

    //Function that changes the ube material to its starting material.
    public void ResetMaterial()
    {
        gameObject.GetComponent<MeshRenderer>().material = startMaterial;
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.name == "CustomHandLeft" || collision.gameObject.name == "CustomHandRight")
    //    {
    //        //check to see if list isnt empty
    //        if (gameController.GetComponent<Controller>().inputOrder.Count > 0)
    //        {
    //            if (index > -1)
    //            {
    //                gameController.GetComponent<Controller>().inputOrder.RemoveAt(index);
    //            }
    //        }
    //    }
    //}
}
