using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheelController : MonoBehaviour
{
    private bool rotateWheel = false;

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

        //TODO: this is quick and dirty... change later
        if (_lotusFlowerCathes == 5)
        {
            Invoke("startWheelRotation", 6.5f);
        }
    }

    void Update()
    {
        if(rotateWheel)
        {
            transform.Rotate(0, 0, 10 * Time.deltaTime);
        }
    }

    void startWheelRotation()
    {
        rotateWheel = true;        
    }
}
