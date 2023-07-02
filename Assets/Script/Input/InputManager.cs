using UnityEngine;
using UnityEngine.InputSystem;

[DefaultExecutionOrder(-1)]
public class InputManager : Singleton<InputManager>
{
    // Source -> https://youtu.be/XUx_QlJpd0M
    public delegate void PressTouch(Vector2 position);
    public event PressTouch OnPressTouch;

    private PlayerControls playerControl;
    private Camera mainCamera;

    private void Awake()
    {
        playerControl = new PlayerControls();
        mainCamera = Camera.main;
    }

    private void OnEnable()
    {
        playerControl.Enable();
    }

    private void OnDisable()
    {
        playerControl.Disable();
    }
    private void Start()
    {
        playerControl.Touch.PrimaryPosition.started += ctx => PrimaryPosition(ctx);
    }
    public void PrimaryPosition(InputAction.CallbackContext context)
    {
        if (OnPressTouch != null) OnPressTouch(Utils.ScreenToWorld(mainCamera, playerControl.Touch.PrimaryPosition.ReadValue<Vector2>()));
    }
}
