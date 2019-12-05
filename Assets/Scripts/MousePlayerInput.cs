using System;
using UnityEngine;

public class MousePlayerInput : MonoBehaviour, IPlayerInput
{
    private float hInput, vInput;
    private Camera cam;

    private Vector3 targetPosition;
    private Vector3 distanceVector;
    private float distanceToTarget;
    private Vector3 direction;
    public float stopRadius = 0.1f;

    public float HInput => hInput;
    //public float HInput { get { return hInput; } }
    public float VInput => vInput;
    public event Action OnJumpPressed;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo = new RaycastHit();
            if (Physics.Raycast(ray, out hitInfo)){
                targetPosition = hitInfo.point;
            }
        }

        distanceVector = (targetPosition - transform.position);
        distanceToTarget = distanceVector.magnitude;

        if (distanceToTarget > stopRadius)
        {
            direction = distanceVector.normalized;
            hInput = direction.x;
            vInput = direction.z;
        } else
        { // if (distanceToTarget <= stopRadius)
            hInput = vInput = 0;
        }

    }
}
