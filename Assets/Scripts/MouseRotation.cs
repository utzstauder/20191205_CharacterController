using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotation : MonoBehaviour
{
    public float speedX = 1f;
    public float speedY = 1f;

    private void LateUpdate()
    {
        if (speedX > 0)
        {
            transform.Rotate(0, speedX * Time.deltaTime * Input.GetAxis("Mouse X"), 0);
        }

        if (speedY > 0)
        {
            transform.Rotate(speedY * Time.deltaTime * Input.GetAxis("Mouse Y") * -1, 0, 0);
        }
    }
}
