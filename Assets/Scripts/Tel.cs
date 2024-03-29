﻿using Newtonsoft.Json.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tel : MonoBehaviour
{
    public GameObject targetObj;
    public GameObject toObj;

    private bool isCheck = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            targetObj = collision.gameObject;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") && isCheck == true)
        {
            StartCoroutine(Teleport());
        }
    }

    IEnumerator Teleport()
    {
        yield return null;
        targetObj.transform.position = toObj.transform.position;
        isCheck = false;
        toObj.SetActive(false);
        gameObject.SetActive(false);
    }
}
