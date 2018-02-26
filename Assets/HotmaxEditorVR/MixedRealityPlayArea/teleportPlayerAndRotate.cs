using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportPlayerAndRotate : MonoBehaviour
{
    public Transform teleportToSpot;

    public void teleportAndRotate()
    {
        init.player.transform.position = teleportToSpot.position;
        init.player.transform.eulerAngles = new Vector3(0, teleportToSpot.eulerAngles.y, 0);
    }
}
