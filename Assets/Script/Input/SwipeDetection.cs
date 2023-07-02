using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeDetection : MonoBehaviour
{
    // Source -> https://youtu.be/XUx_QlJpd0M

    private InputManager inputManager;

    [SerializeField] private float speed = 10.0f;
    private bool hasStartedMoving = false;
    private Vector3 targetPosition;

    private void Awake()
    {
        inputManager = InputManager.Instance;
    }

    private void OnEnable()
    {
        inputManager.OnPressTouch += Test;
    }

    private void OnDisable()
    {
        inputManager.OnPressTouch -= Test;
    }

    private void Update()
    {
        Debug.Log(hasStartedMoving);
        if (hasStartedMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, targetPosition) < 0.15f)
            {
                hasStartedMoving = false;
            }
        }
    }

    private void Test(Vector2 position)
    {
        Debug.Log(position);
        targetPosition = new Vector3(position.x, transform.position.y, transform.position.z);
        hasStartedMoving = true;
    }
}
