﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mazeMap : MonoBehaviour
{
    private void OnEnable()
    {
        
    }

    private void Update()
    {
        transform.Rotate(0, 0, 10 * Time.deltaTime);
    }
}
