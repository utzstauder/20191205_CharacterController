using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLight : MonoBehaviour
{
    Light light;

    private void Awake()
    {
        light = GetComponent<Light>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            light.enabled = !light.enabled;
        }
    }
}
