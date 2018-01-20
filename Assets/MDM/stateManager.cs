using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stateManager : MonoBehaviour
{
    public static int powerOrbHit = 0;
    public static bool isSuperArrow = false;
    public delegate void powerOrbHitHandler(int value);
    public static event powerOrbHitHandler powerOrbHitEvent;

    public void SET_POWER_ORB_HIT(int value)
    {
        powerOrbHit = value;
        if (powerOrbHitEvent != null)
        {
            powerOrbHitEvent(value);
        }
    }
}
