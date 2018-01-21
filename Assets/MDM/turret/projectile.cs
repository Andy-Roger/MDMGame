using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    private void Start()
    {
        Invoke("destroyGameObject", 10);
        GetComponent<Rigidbody>().velocity = transform.forward * 20;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //TODO: instantiate an explosion where this object is
        GameObject projectileExplosion = Instantiate(Resources.Load("projectileExplosion", typeof(GameObject))) as GameObject;
        projectileExplosion.transform.position = transform.position;
        Destroy(gameObject);
    }

    void removeGameObject()
    {
        Destroy(gameObject);
    }
}
