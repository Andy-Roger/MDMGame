using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mazeMapController : MonoBehaviour
{

    public GameObject mazeMap;

    private void Start()
    {
        inputManager.trackedController1.MenuButtonClicked += menuButton1Clicked;
        inputManager.trackedController2.MenuButtonClicked += menuButton2Clicked;
        inputManager.trackedController1.MenuButtonUnclicked += menuButton1Unclicked;
        inputManager.trackedController2.MenuButtonUnclicked += menuButton2Unclicked;
    }

    private void OnApplicationQuit()
    {
        inputManager.trackedController1.MenuButtonClicked -= menuButton1Clicked;
        inputManager.trackedController2.MenuButtonClicked -= menuButton2Clicked;
        inputManager.trackedController1.MenuButtonUnclicked -= menuButton1Unclicked;
        inputManager.trackedController2.MenuButtonUnclicked -= menuButton2Unclicked;
    }

    void menuButton1Clicked(object sender, ClickedEventArgs e)
    {
        placeMap(inputManager.trackedController1);
    }

    void menuButton2Clicked(object sender, ClickedEventArgs e)
    {
        placeMap(inputManager.trackedController2);
    }

    void menuButton1Unclicked(object sender, ClickedEventArgs e)
    {
        mazeMap.transform.parent = null;
        mazeMap.SetActive(false);
    }

    void menuButton2Unclicked(object sender, ClickedEventArgs e)
    {
        mazeMap.transform.parent = null;
        mazeMap.SetActive(false);
    }

    void placeMap(SteamVR_TrackedController trackedController)
    {
        Vector3 controllerWorldPos = trackedController.transform.position;
        mazeMap.transform.position = new Vector3(controllerWorldPos.x, controllerWorldPos.y + .1f, controllerWorldPos.z);
        mazeMap.transform.localEulerAngles = new Vector3(-90, 0, 0);
        mazeMap.SetActive(true);
    }
}
