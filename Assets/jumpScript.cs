using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class jumpScript : MonoBehaviour, IVirtualButtonEventHandler {

    private GameObject jumpButtonObject;
    private GameObject trump;
    private int i;

    [Range(1, 10)]
    public float jumpVelocity;

    // Use this for initialization
    void Start()
    {
        jumpButtonObject = GameObject.Find("jumpButton");
        trump = GameObject.Find("trump");

        jumpButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        i = 1;
    }


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Jump 1");
        trump.transform.Rotate(0, ((i * 90) % 360), 0, Space.World);
        i++;
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Jump 0");
    }

	
}
