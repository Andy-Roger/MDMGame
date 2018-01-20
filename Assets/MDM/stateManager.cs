using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stateManager : MonoBehaviour
{
    public static int powerOrbHit = 0;
    public delegate void powerOrbHitHandler(int value);
    public static event powerOrbHitHandler powerOrbHitEvent;

    public static bool superArrowMode = true;
    public delegate void superArrowModeHandler(bool value);
    public static event superArrowModeHandler superArrowModeEvent;

    public void SET_POWER_ORB_HIT(int value)
    {
        powerOrbHit = value;
        if (powerOrbHitEvent != null)
        {
            powerOrbHitEvent(value);
        }
    }

    public void SET_SUPER_ARROW_MODE(bool value)
    {
        superArrowMode = value;
        if(superArrowModeEvent != null)
        {
            superArrowModeEvent(value);
        }
    }
}
