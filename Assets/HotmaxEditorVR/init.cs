﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class init : MonoBehaviour {

    //-- reference hooks
    //-- used for classes that frequently get destroyed but need reference to a gameObject
    public static GameObject rotationGizmos;
    public static GameObject props;
    public static GameObject deletePanel;
    public static GameObject deletedProps;
    public static GameObject handColliderFollow;
    public static GameObject vrCamera;
    public static GameObject scaleController;
    public static GameObject player;

    public static stateManager stateManager;
    public static GameObject powerCore;
    public static GameObject headCollider;
    public static GameObject playerFollow;


    public static stateManager _stateManagerMutatorRef;

    void Awake ()
    {
        rotationGizmos = GameObject.Find("rotationGizmos");
        props = GameObject.Find("props");
        deletePanel = GameObject.Find("deletePanel");
        deletedProps = GameObject.Find("deletedProps");
        vrCamera = GameObject.Find("VRCamera");
        scaleController = GameObject.Find("scaleController");
        player = GameObject.Find("Player");

        _stateManagerMutatorRef = GameObject.FindObjectOfType(typeof(stateManager)) as stateManager;

        stateManager = GameObject.FindObjectOfType(typeof(stateManager)) as stateManager;
        powerCore = GameObject.Find("powerCore");
        headCollider = GameObject.Find("HeadCollider");
        playerFollow = GameObject.Find("playerFollow (for map)");

    }
}
