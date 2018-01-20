using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turret : MonoBehaviour
{
    public GameObject projectile;
    public GameObject barrelHolder;
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
            GameObject projectileRef = Instantiate(projectile);
            projectileRef.transform.position = barrelHolder.transform.position;
            projectileRef.transform.rotation = barrelHolder.transform.rotation;
            Physics.IgnoreCollision(projectileRef.GetComponent<Collider>(), GetComponent<Collider>());
        }

        Invoke("releaseProjectile", repeatRate);
    }

    void Update()
    {
        var targetRotation = Quaternion.LookRotation(init.vrCamera.transform.position - barrelHolder.transform.position);
        barrelHolder.transform.rotation = Quaternion.Slerp(barrelHolder.transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        GameObject turretExplosion = Instantiate(Resources.Load("turretExplosion", typeof(GameObject)), transform.position, Quaternion.identity ) as GameObject;
    }
}
