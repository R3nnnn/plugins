using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public GameObject mainCamera;
    void Start()
    {
        mainCamera.GetComponent<Effects>();
    }

    public void Activate()
    {
        if(mainCamera.GetComponent<Effects>().enabled != true)
        {
            mainCamera.GetComponent<Effects>().enabled = true;
        }
        
    }

    public void Deactivate()
    {
        if (mainCamera.GetComponent<Effects>().enabled != false)
        {
            mainCamera.GetComponent<Effects>().enabled = false;
        }
    }

}
