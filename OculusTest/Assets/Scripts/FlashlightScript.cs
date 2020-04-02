using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightScript : MonoBehaviour
{
    public GameObject beam;
    public GameObject RightHand;
    public GameObject LeftHand;
    bool On = false;
    // Start is called before the first frame update
    void Start()
    {
        LeftHand = GameObject.Find("AvatarGrabberLeft");
        RightHand = GameObject.Find("AvatarGrabberRight");
        beam.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<OVRGrabbable>().isGrabbed)
        {
            Debug.Log(gameObject.GetComponent<OVRGrabbable>().grabbedBy);
            if (gameObject.GetComponent<OVRGrabbable>().grabbedBy.name == "CustomHandLeft" || gameObject.GetComponent<OVRGrabbable>().grabbedBy.name == "AvatarGrabberLeft")
            {
                if (OVRInput.Get(OVRInput.RawButton.LIndexTrigger))
                {         
                    if (On)
                    {
                        On = false;
                    }
                    else
                    {
                        On = true;
                    }
                }
            }
            if (gameObject.GetComponent<OVRGrabbable>().grabbedBy.name == "CustomHandRight" || gameObject.GetComponent<OVRGrabbable>().grabbedBy.name == "AvatarGrabberRight")
            {
                if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
                {
                    if (On)
                    {
                        On = false;
                    }
                    else
                    {
                        On = true;
                    }
                }
            }
        }

        //if (gameObject.GetComponent<OVRGrabbable>().grabbedBy == RightHand)
        //{
        //    Debug.Log("Right");
        //    if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
        //    {
        //        if (On)
        //        {
        //            On = false;
        //        }
        //        else
        //        {
        //            On = true;
        //        }
        //    }
        //}

        beam.SetActive(On);

    }
}
