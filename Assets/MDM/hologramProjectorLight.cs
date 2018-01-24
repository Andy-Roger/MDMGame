using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hologramProjectorLight : MonoBehaviour {

    private Material pointInMapMat;

    void Start ()
    {
        pointInMapMat = GetComponent<MeshRenderer>().material;
    }

    void Update ()
    {
        pointInMapMat.color = new Color(pointInMapMat.color.r, pointInMapMat.color.g, pointInMapMat.color.b, Mathf.Sin(pointInMapMat.color.a) * 40);

    }
}
