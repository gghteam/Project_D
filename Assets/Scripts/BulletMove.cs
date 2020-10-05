using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BulletMove : MonoBehaviour
{
    public Rigidbody2D rb;
    //floa  t randomX, randomY;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.rotation = GameObject.Find("Balssa").transform.rotation;
        rb.AddRelativeForce(Vector2.up * GameManager.Instance.speed);
    }

    void Update()
    {
        //transform.Translate(Vector2.up * Time.deltaTime * GameManager.Instance.bulletSpeed);
    }

}
