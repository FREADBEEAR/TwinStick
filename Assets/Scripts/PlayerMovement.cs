using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    private Rigidbody playerbody;

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

    private void Start()
    {
        playerTransform = this.gameObject.GetComponent<Transform>();

        playerbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
       moveInput = moveAction.action.ReadValue<Vector2>();
       lookInput = lookAction.action.ReadValue<Vector2>();
        

        

        Vector2 direction = -lookInput;

        if (lookAction.action.activeControl?.device is Mouse)
        { 
            Vector2 playerOnScreen = Camera.main.WorldToScreenPoint(transform.position);
            direction = playerOnScreen - Mouse.current.position.ReadValue();

        }

        if (direction.sqrMagnitude > 0.05f)
        {
            transform.forward = new Vector3(direction.x, 0f, direction.y);

        }








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

    private void FixedUpdate()
    {
        Vector2 direction = moveInput.normalized;
        float speed = playerMovementSpeed * movementSpeedMultiplier;

        playerbody.linearVelocity = new Vector3(
            direction.x * speed,
            playerbody.linearVelocity.y,
            direction.y * speed
        );

    }


}