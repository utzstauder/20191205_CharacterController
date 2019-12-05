using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueReferenceDemo : MonoBehaviour
{
    Vector3 a = new Vector3(10, 0, 0);
    Vector3 b = new Vector3(0, 20, 0);

    void Start()
    {
        Output();
        AddAndOutput(out a, b);
        Output();
    }

    void AddAndOutput(out Vector3 n1, Vector3 n2)
    {
        n1 = n2;
        Debug.Log("n1 = " + n1);
    }

    private void Output()
    {
        Debug.Log("a = " + a);
        Debug.Log("b = " + b);
    }
}
