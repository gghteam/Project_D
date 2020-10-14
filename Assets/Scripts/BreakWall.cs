using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakWall : MonoBehaviour
{
    private int Break = 2;
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.tag == "Player")
        {
            Break -= 1;
        }
    }

    private void Update()
    {
        if(Break == 0)
        {
            gameObject.SetActive(false);
        }
    }
}
