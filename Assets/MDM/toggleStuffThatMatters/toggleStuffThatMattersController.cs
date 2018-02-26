using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleStuffThatMattersController : MonoBehaviour
{
    public List<turret> turretBehaviours = new List<turret>();


    //--local ref
    private int _currentStage;

    private void Start()
    {
        stateManager.setCurrentStageEvent += updateCurrentStageEvent;
        init.stateManager.SET_CURRENT_STAGE(1);
    }

    private void OnApplicationQuit()
    {
        stateManager.setCurrentStageEvent -= updateCurrentStageEvent;
    }

    void updateCurrentStageEvent(int value)
    {
        _currentStage = value;

        switch (_currentStage)
        {
            case 1:
                print("turn off stage 2 / 3 stuff");
                break;
            case 2:
                foreach(turret turretBehaviour in turretBehaviours)
                {
                    turretBehaviour.enabled = true;
                }
                break;
            default:
                print("turn off stage 1 / 2 stuff");
                break;
        }
    }
}
