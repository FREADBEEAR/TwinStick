using UnityEditor.ShaderGraph.Internal;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{

    float horInput;
    float verInput;

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

        playerTransform.Translate(playerPosition.normalized * playerMovementSpeed * Time.deltaTime, Space.World);
        playerPosition = Vector3.zero;

        Vector3 mouseDirection = Input.mousePosition - Camera.main.WorldToScreenPoint(this.transform.position);

        float angle = Mathf.Atan2(mouseDirection.x, mouseDirection.y) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.Euler(0f, angle, 0f);




    }

}
