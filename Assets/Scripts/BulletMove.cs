using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BulletMove : MonoBehaviour
{

    


    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * GameManager.Instance.bulletSpeed);
    }

}
