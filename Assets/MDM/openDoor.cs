using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour
{
    public Valve.VR.InteractionSystem.LinearMapping linearMapping;

    void Update ()
    {
		transform.localPosition = new Vector3(0, linearMapping.value * 2.5f, 0);
	}
}
