using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3FloorScript : MonoBehaviour
{
    public GameObject ball;
    public GameObject temp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
                Instantiate(ball, new Vector3(-0.288f, 0.95f, 0), Quaternion.identity);
                temp = collision.gameObject;
                temp.GetComponent<Baskeball>().destroy = true;
        }
    }
}
