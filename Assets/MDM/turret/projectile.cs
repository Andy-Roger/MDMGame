using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{

    private Rigidbody rb;
    private Transform _caughtWithHand;
    private bool moveProjectile = false;

    private void Start()
    {
        Invoke("destroyGameObject", 10);
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * 400 * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name != "sheildCollider")
        {
            //GameObject projectileExplosion = Instantiate(Resources.Load("projectileExplosion", typeof(GameObject))) as GameObject;
            //projectileExplosion.transform.position = transform.position;
            //Destroy(gameObject);
        }
    }

    public void fireFromHand()
    {
        //moveProjectile = true;
        Invoke("moveVel", .1f);
        Invoke("destroyGameObject", 10);
    }

    private void Update()
    {
        if (moveProjectile)
        {
            rb.velocity = _caughtWithHand.forward * 400 * Time.deltaTime;
        }
    }

    public void saveCaughtWithHand()
    {
        CancelInvoke();
        _caughtWithHand = transform.parent;
    }

    void moveVel()
    {
        rb.velocity = _caughtWithHand.forward * 1000 * Time.deltaTime;
    }

    void destroyGameObject()
    {
        Destroy(gameObject);
    }
}
