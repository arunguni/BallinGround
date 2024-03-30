using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleDown : MonoBehaviour
{

    public float scaleFactor = 0.9f;

    public void ScaleBallDown()
    {
        transform.localScale *= scaleFactor;
    }
}
