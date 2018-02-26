using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class stageMoveController : MonoBehaviour
{
    //--local refs
    private int _lotusFlowerCathes;

    private void Start()
    {
        stateManager.lotusCatchCountEvent += updateLotusCatchCount;
    }

    private void OnApplicationQuit()
    {
        stateManager.lotusCatchCountEvent -= updateLotusCatchCount;
    }

    void updateLotusCatchCount(int value)
    {
        _lotusFlowerCathes = value;

        if (_lotusFlowerCathes == 5)
        {
            Invoke("movePlatform", 10);
        }
    }

    void movePlatform()
    {
        float stageMoveTime = 15;
        transform.DOMoveY(38.707f, stageMoveTime);
        Invoke("setToStageTwo", stageMoveTime);
    }

    void setToStageTwo()
    {
        init.stateManager.SET_CURRENT_STAGE(2);
    }
}
