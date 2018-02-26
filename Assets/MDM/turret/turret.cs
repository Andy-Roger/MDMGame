using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turret : MonoBehaviour
{
    public GameObject projectile;
    public GameObject barrelHolder;
    public GameObject motionSenser;
    public float rotationSpeed = 4;

    void Start()
    {
        Invoke("releaseProjectile", 2);
    }

    void releaseProjectile()
    {
        RaycastHit hit;
        float repeatRate = Random.Range(2, 5);

        if (Physics.Raycast(barrelHolder.transform.position, barrelHolder.transform.forward, out hit, Mathf.Infinity))
        {
            if (hit.collider.gameObject == init.headCollider)
            {
                GameObject projectileRef = Instantiate(projectile);
                projectileRef.transform.position = barrelHolder.transform.position;
                projectileRef.transform.rotation = barrelHolder.transform.rotation;
                Physics.IgnoreCollision(projectileRef.GetComponent<Collider>(), GetComponent<Collider>());
            }
        }

        Invoke("releaseProjectile", repeatRate);
    }

    void Update()
    {
        motionSenser.transform.LookAt(init.headCollider.transform);

        RaycastHit hit;
        if (Physics.Raycast(motionSenser.transform.position, motionSenser.transform.forward, out hit, Mathf.Infinity))
        {
            if (hit.collider.gameObject == init.headCollider)
            {
                var targetRotation = Quaternion.LookRotation(init.vrCamera.transform.position - barrelHolder.transform.position);
                barrelHolder.transform.rotation = Quaternion.Slerp(barrelHolder.transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "projectile")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            GameObject turretExplosion = Instantiate(Resources.Load("turretExplosion", typeof(GameObject)), transform.position, Quaternion.identity) as GameObject;
        }
    }
}
