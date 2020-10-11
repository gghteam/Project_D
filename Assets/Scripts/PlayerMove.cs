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
        GameObject.Find("GameManager").GetComponent<GameManager>().downCheck = true;
    }

    void Start()
    {
        
    }

    void Update()
    {

        /*if(Input.GetButtonUp("PlayerCheck"))
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().downCheck = true;
        }*/
    }
}
