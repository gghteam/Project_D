using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMove : MonoSingleton<PlayerMove>, IPointerDownHandler, IPointerUpHandler
{
    public bool isCheck = false;
    public void OnPointerDown(PointerEventData eventData)
    {
        isCheck = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        isCheck = false;
    }

    void Start()
    {
        
    }

    void Update()
    {

        if(Input.GetButtonUp("Fire1"))
        {
            GameObject.Find("Point").GetComponent<Rotate>().downCheck = true;
        }
    }
}
