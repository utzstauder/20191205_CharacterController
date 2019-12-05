using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float movementSpeed = 2f;

    private float hInput, vInput;

    private IPlayerInput input;

    private void Awake()
    {
        input = GetComponent<IPlayerInput>();

        input.OnJumpPressed += Input_OnJumpPressed;
    }

    private void Input_OnJumpPressed()
    {
        Debug.Log("CharacterController: jump");
    }

    private void Update()
    {
        if (input == null) return;

        hInput = input.HInput;
        vInput = input.VInput;

        transform.position +=
            (transform.right * hInput + transform.forward * vInput).normalized * movementSpeed * Time.deltaTime;
    }
}
