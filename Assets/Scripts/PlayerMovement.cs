using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private InputActionReference moveAction;
    [SerializeField] private InputActionReference lookAction;
    [SerializeField] private InputActionReference sprintAction;
    [SerializeField] private InputActionReference sneakAction;

    Vector2 lookInput;
    Vector2 moveInput;

    float movementSpeedMultiplier = 1;
    public bool isSpeeding = false;

    public float playerMovementSpeed = 10;

    Transform playerTransform;
    Vector3 playerPosition;

    void Start()
    {
        playerTransform = this.gameObject.GetComponent<Transform>();
    }

    void Update()
    {
       moveInput = moveAction.action.ReadValue<Vector2>();
       lookInput = lookAction.action.ReadValue<Vector2>();
        Debug.Log("Move Input: " + moveInput);

        playerPosition = new Vector3(moveInput.x, 0, moveInput.y);

        playerTransform.Translate(playerPosition.normalized * playerMovementSpeed * movementSpeedMultiplier * Time.deltaTime, Space.World);
        playerPosition = Vector3.zero;

        Vector3 mouseDirection = Input.mousePosition - Camera.main.WorldToScreenPoint(this.transform.position);

        float angle = Mathf.Atan2(mouseDirection.x, mouseDirection.y) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.Euler(0f, angle, 0f);
        // Check if the Left Shift key is pressed
        if (sprintAction.action.IsPressed())
        {
            Debug.Log(moveInput + "is on");
            movementSpeedMultiplier = 2;
        }
        // Check if the Left Control key is pressed
        else if (sneakAction.action.IsPressed())
        {


            movementSpeedMultiplier = 0.5f;
        }
        else
        {// Reset to default speed when neither key is pressed
            movementSpeedMultiplier = 1;
        }

        if(isSpeeding == true)
        {
            Debug.Log(isSpeeding + "is on");
            movementSpeedMultiplier = movementSpeedMultiplier * 2;

        }
    }

    private void OnEnable()
    {
        moveAction.action.Enable();
        lookAction.action.Enable();
        sprintAction.action.Enable();
        sneakAction.action.Enable();
    }

    private void OnDisable()
    {
        moveAction.action.Disable();
        lookAction.action.Disable();
        sprintAction.action.Disable();
        sneakAction.action.Disable();
    }

}