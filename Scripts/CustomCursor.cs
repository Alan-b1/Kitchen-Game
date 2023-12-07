using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCursor : MonoBehaviour
{
    public void Awake()
    {
        transform.position = Input.mousePosition;
    }

    public void Update()
    {
        transform.position = Input.mousePosition;
    }
}
