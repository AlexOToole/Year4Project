﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baskeball : MonoBehaviour
{
    GameObject gameController;
    public bool destroy = false;
    float timer = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.FindWithTag("Hoop");
    }

    // Update is called once per frame
    void Update()
    {
        if (destroy)
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