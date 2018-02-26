using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class playerMoveController : MonoBehaviour
{
    //--local refs
    private int _lotusFlowerCathes;
    public Transform stage;

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
            transform.parent = stage;
        }
    }

    void movePlatform()
    {
        float stageMoveTime = 15;
        transform.DOMoveY(38.707f, stageMoveTime);
    }
}
