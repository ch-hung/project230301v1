using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowFollow : MonoBehaviour
{
    [SerializeField] private Camera MainCamera;
    void LateUpdate()
    {
        float mouseX = MainCamera.ScreenToWorldPoint(Input.mousePosition).x;
        if (mouseX > 4)
        {
            mouseX = 4;
        }
        else if (mouseX < -4)
        {
            mouseX = -4;
        }
        transform.position =new Vector3(mouseX, 4.3f, 0f);
    }
}
