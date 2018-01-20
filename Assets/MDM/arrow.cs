using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
    public GameObject arrowTip;

    private void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = arrowTip.transform.position;
        cube.transform.rotation = other.transform.rotation;
        cube.GetComponent<BoxCollider>().enabled = false;
        cube.GetComponent<MeshRenderer>().enabled = false;
        cube.transform.parent = other.transform;
        transform.parent = cube.transform;
    }
}
