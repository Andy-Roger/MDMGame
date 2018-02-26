using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeGarbageMattePic : MonoBehaviour
{
    public GameObject cameraForScreenShot;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            turnOnCamera(true);
            Invoke("takePicture", .5f);
        }
    }

    void takePicture()
    {
        ScreenCapture.CaptureScreenshot("garbageMatteScreenShot.png");
        invokeTurnOff();
    }

    void turnOnCamera(bool on)
    {
        cameraForScreenShot.SetActive(on);
    }

    void turnOffCamera()
    {
        cameraForScreenShot.SetActive(false);
    }

    void invokeTurnOff()
    {
        Invoke("turnOffCamera", .5f);
    }
}
