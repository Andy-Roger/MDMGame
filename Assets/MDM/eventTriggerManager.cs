using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventTriggerManager : MonoBehaviour
{

    //--local refs
    private int _powerOrbHits;
    private int _lotusFlowerCathes;

    private void Start()
    {
        stateManager.powerOrbHitEvent += updatePowerOrbHit;
        stateManager.lotusCatchCountEvent += updateLotusCatchCount;
    }

    private void OnApplicationQuit()
    {
        stateManager.powerOrbHitEvent -= updatePowerOrbHit;
        stateManager.lotusCatchCountEvent -= updateLotusCatchCount;
    }

    void updatePowerOrbHit(int value)
    {
        _powerOrbHits = value;

        if (_powerOrbHits == 10)
        {
            init.powerCore.transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    void updateLotusCatchCount(int value)
    {
        _lotusFlowerCathes = value;

        if(_lotusFlowerCathes == 5)
        {
            print("This fires when the statue cates them all!");
        }
    }
}
