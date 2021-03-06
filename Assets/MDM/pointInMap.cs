﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointInMap : MonoBehaviour {

    private Material pointInMapMat;

    private void Start()
    {
        pointInMapMat = GetComponent<MeshRenderer>().material;
    }

    void Update()
    {
        transform.localPosition = init.playerFollow.transform.localPosition;
        pointInMapMat.color = new Color(pointInMapMat.color.r, pointInMapMat.color.g, pointInMapMat.color.b, Mathf.Sin(pointInMapMat.color.a) * 40);
    }
}
