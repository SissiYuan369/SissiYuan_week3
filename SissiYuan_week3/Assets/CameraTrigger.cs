using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    //public Camera myCamera;

    public Camera currentCam;
    public Camera previousCam;//Thisiswhere the previous camera goes to turn it off. 

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            //myCamera.gameObject.SetActive(true);
            //Camera.main.gameObject.SetActive(false);
            previousCam.enabled = false;
            currentCam.enabled = true;


        }
    }
}