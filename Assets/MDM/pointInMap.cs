using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointInMap : MonoBehaviour {

	void Update ()
    {
        transform.localPosition = init.playerFollow.transform.localPosition;
	}
}
