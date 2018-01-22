using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFollow : MonoBehaviour
{

	void Update ()
    {
        transform.position = init.vrCamera.transform.position;
	}
}
