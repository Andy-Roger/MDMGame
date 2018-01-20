using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class init : MonoBehaviour
{
    public static stateManager stateManager;
    public static GameObject powerCore;
    public static GameObject vrCamera;


    private void Awake()
    {
        stateManager = GameObject.FindObjectOfType(typeof(stateManager)) as stateManager;
        powerCore = GameObject.Find("powerCore");
        vrCamera = GameObject.Find("VRCamera");
    }
}
