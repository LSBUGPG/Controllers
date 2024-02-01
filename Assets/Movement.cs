using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;

public class Movement : MonoBehaviour
{
    public PlayerInput input;
    public Controller controller;
    Vector2 direction;

    void Start()
    {
        InputUser user = input.user;
        user.UnpairDevices();
        InputUser.PerformPairingWithDevice(controller.device, user);
    }

    void Update()
    {
        transform.Translate(direction * Time.deltaTime);
    }

    public void OnMove(InputValue value)
    {
        direction = value.Get<Vector2>();
    }
}
