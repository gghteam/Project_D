using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Xml.Schema;
using UnityEngine;
using UnityEngine.EventSystems;

public class Rotate : MonoBehaviour

{
    private float z = 0f;
    private bool Check = false;
    public GameObject Pl;
    public Transform FirePos;

    

    void Start()
    {
        
    }

    private IEnumerator Moving()
    {
        yield return null;
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
            //Debug.Log("최대치");
            Check = false;
        }

        if (z >= 91)
        {
            //Debug.Log("최소치");
            Check = true;
        }
    }

    void Update()
    {
        if(GameObject.Find("PlayerCheck").GetComponent<PlayerMove>().isCheck ==false)
        {
            StartCoroutine(Moving());
        }
        if(GameObject.Find("PlayerCheck").GetComponent<PlayerMove>().isCheck == true)
        {
            StopCoroutine(Moving());
            transform.localScale = new Vector2(transform.localScale.x+0.001f,transform.localScale.y+0.001f);
            GameManager.Instance.bulletSpeed += 0.1f;
        }
        if (GameManager.Instance.downCheck == true)
        {
            Instantiate(Pl, FirePos.transform.position, FirePos.transform.rotation);
            //gameObject.SetActive(false);
            //GameObject.Find("pre_directiongauge").SetActive(false);
            //GameObject.Find("PlayerCheck").SetActive(false);
            GameManager.Instance.downCheck = false;
        }
    }
}
