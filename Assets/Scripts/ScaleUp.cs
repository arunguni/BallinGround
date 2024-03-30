using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScaleUp : MonoBehaviour
{

    public float scaleFactor = 1.1f;

    public void ScaleBallUp()
    {
        transform.localScale *= scaleFactor;
    }
}
