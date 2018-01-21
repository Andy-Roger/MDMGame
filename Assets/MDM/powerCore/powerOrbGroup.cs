using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerOrbGroup : MonoBehaviour {

    //--local refs
    private int _powerOrbHits;

    public float rotationSpeed = 10;

    public Vector3 rotationDirection;

    void Update()
    {
        transform.Rotate(rotationDirection.x, rotationSpeed * stateManager.powerOrbHit * Time.deltaTime, rotationDirection.z);
    }
}
