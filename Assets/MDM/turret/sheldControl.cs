using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sheldControl : MonoBehaviour {

    public Transform handle;

	void Update ()
    {
        transform.position = handle.position;
        transform.rotation = handle.rotation;
	}
}
