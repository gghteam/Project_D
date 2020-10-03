using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class BulletMove : MonoBehaviour
{
    [SerializeField] float speed = 1000f;
    public Rigidbody2D rb;
    //floa  t randomX, randomY;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.rotation = GameObject.Find("Balssa").transform.rotation;
        rb.AddRelativeForce(Vector2.up * speed);
    }

    void Update()
    {
        //transform.Translate(Vector2.up * Time.deltaTime * GameManager.Instance.bulletSpeed);
    }

}
