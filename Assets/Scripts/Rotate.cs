using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private float z = 0f;
    public float direction = 1f; // initial direction
    private bool Check = false;
 
    void Update()
    {
        if (Check == true)
        {
            z -= Time.deltaTime * 100;
            transform.rotation = Quaternion.Euler(0, 0, z);
        }

        if (Check == false)
        {
            z += Time.deltaTime * 100;
            transform.rotation = Quaternion.Euler(0, 0, z);
        }
        //최대치 도달시 반대로 회전
        if (z <= -90)
        {
            Debug.Log("최대치");
            Check = false;
        }

        if (z >= 91)
        {
            Debug.Log("최소치");
            Check = true;
        }
    }
}
