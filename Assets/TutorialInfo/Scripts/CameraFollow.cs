using UnityEngine;
using UnityEngine.UIElements;

public class CameraFollow : MonoBehaviour
{

    [SerializeField] private Transform player;
    [SerializeField] private Vector3 offset;

    void LateUpdate()
    {
        this.transform.position = player.transform.position + offset;
    }

}