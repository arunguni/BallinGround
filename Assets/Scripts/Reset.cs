using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Reset : MonoBehaviour
{
    private Vector3 initialPosition;
    private Vector3 initialScale;

    void Start()
    {
        initialPosition = transform.position;
        initialScale = transform.localScale;
    }
    public void ResetToInitialPosition()
    {
        transform.position = initialPosition;
        transform.localScale = initialScale;
    }
}
