using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveUp : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{


    bool isPressed = false;
    public GameObject Ball;
    public float Force;

    // Update is called once per frame
    void Update()
    {
        if (isPressed)
        {
            Ball.transform.Translate(0, 0, Force * Time.deltaTime);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }
}
