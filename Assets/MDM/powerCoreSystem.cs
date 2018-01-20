using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerCoreSystem : MonoBehaviour
{
    //--local refs
    private int _powerOrbHits;

    public float rotationSpeed = 10;

    private void Start()
    {
        stateManager.powerOrbHitEvent += updatePowerOrbHit;
    }

    private void OnApplicationQuit()
    {
        stateManager.powerOrbHitEvent -= updatePowerOrbHit;
    }

    void updatePowerOrbHit(int value)
    {
        _powerOrbHits = value;

        if(_powerOrbHits == 10)
        {
            init.powerCore.transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
