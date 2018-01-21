using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerOrb : MonoBehaviour
{
    public Transform powerCore;
    private int hitCount = 0;

    private void Update()
    {
        transform.LookAt(powerCore);
    }

    private void OnCollisionEnter(Collision other)
    {
        hitCount += 1;

        if(hitCount <= 1)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            init.stateManager.SET_POWER_ORB_HIT(stateManager.powerOrbHit += hitCount);
        }
    }
}
