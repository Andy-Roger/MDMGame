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
        mazeMap.transform.parent = inputManager.trackedController1.transform;
        mazeMap.transform.localPosition = Vector3.up;
        mazeMap.SetActive(true);
    }

    void menuButton2Clicked(object sender, ClickedEventArgs e)
    {
        mazeMap.transform.parent = inputManager.trackedController2.transform;
        mazeMap.transform.localPosition = Vector3.up;
        mazeMap.SetActive(true);
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
}
