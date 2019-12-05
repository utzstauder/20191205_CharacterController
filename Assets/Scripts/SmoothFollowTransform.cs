using UnityEngine;

public class SmoothFollowTransform : MonoBehaviour
{
    public Transform targetTransform;
    public float smoothSpeed = 0.5f;

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, targetTransform.position, smoothSpeed * Time.deltaTime);
    }
}
