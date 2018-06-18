using System.Collections;
using System.Collections.Generic;
using Vuforia;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class rotateScript : MonoBehaviour, IVirtualButtonEventHandler
{

    private GameObject rotateButtonObject;
    private GameObject trump;
    private int i;

    // Use this for initialization
    void Start()
    {
        rotateButtonObject = GameObject.Find("rotateButton");
        trump = GameObject.Find("trump");

        rotateButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        i = 1;
    }


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("rotate 1");
        trump.transform.Rotate(0, ((i*90)%360), 0, Space.World);
        i++;
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("rotate 0");
    }
}
