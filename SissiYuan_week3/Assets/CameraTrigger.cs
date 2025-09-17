using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    public Camera myCamera;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            myCamera.gameObject.SetActive(true);
            Camera.main.gameObject.SetActive(false);
        }
    }
}