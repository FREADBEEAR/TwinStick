using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UIElements;


public class PlayerMovement : MonoBehaviour
{

    float horInput;
    float verInput;
    float movementSpeedMultiplier = 1;

    public float playerMovementSpeed = 10;

    Transform playerTransform;
    Vector3 playerPosition;

    void Start()
    {
        playerTransform = this.gameObject.GetComponent<Transform>();
    }

    void Update()
    {
        horInput = Input.GetAxis("Horizontal");
        verInput = Input.GetAxis("Vertical");

        if (horInput != 0)
        {
            playerPosition.x += horInput;
        }

        if (verInput != 0)
        {
            playerPosition.z += verInput;
        }

        playerTransform.Translate(playerPosition.normalized * playerMovementSpeed * movementSpeedMultiplier * Time.deltaTime, Space.World);
        playerPosition = Vector3.zero;

        Vector3 mouseDirection = Input.mousePosition - Camera.main.WorldToScreenPoint(this.transform.position);

        float angle = Mathf.Atan2(mouseDirection.x, mouseDirection.y) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.Euler(0f, angle, 0f);
        // Check if the Left Shift key is pressed
        if (Input.GetKey(KeyCode.LeftShift))
        {
            movementSpeedMultiplier = 2;
        }
        // Check if the Left Control key is pressed
        else if (Input.GetKey(KeyCode.LeftControl))
        {
            movementSpeedMultiplier = 0.5f;
        }
        else
        {// Reset to default speed when neither key is pressed
            movementSpeedMultiplier = 1;
        }


    }

}