﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraResolution : MonoBehaviour
{
    public Vector2 standard_resolution;
    public Camera camera1;
    public bool isLandScape;

    private float rate;

    private void Start()
    {
        rate = standard_resolution.y / standard_resolution.x;
    }
    private void Update()
    {
        Setting();
    }
    private void Setting()
    {
        int size = Screen.height - Screen.width;
        bool isScreenWrong = (size > 0 && isLandScape) || (size < 0 && !isLandScape);
        if (isScreenWrong) return;
        float mobile_rate = (float)Screen.height / (float)Screen.width;
        //위아래가 길어지는 경우
        if(mobile_rate > rate)
        {
            float h = rate / mobile_rate;
            camera1.rect = new Rect(0, (1 - h) / 2, 1, h);
        }
        //좌우로 늘어나는 경우
        else
        {
            float w = mobile_rate / rate;
            camera1.rect = new Rect((1 - w) / 2, 0, w, 1);
        }
        this.enabled = false;
    }

}
