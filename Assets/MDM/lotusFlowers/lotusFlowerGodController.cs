using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class lotusFlowerGodController : MonoBehaviour
{

    //--local refs
    private int _lotusFlowerCathes;
    public GameObject laserEyesPS;

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
            Invoke("rotateToWheel", 1.5f);
        }
    }

    void rotateToWheel()
    {
        transform.DOLocalRotate(Vector3.zero, 5, RotateMode.Fast);
        laserEyesPS.SetActive(true);
    }
}
