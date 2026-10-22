using UnityEngine;

public class Collectable : MonoBehaviour
{
    Transform playerTransform;
    Transform colllectableTransform;
    float distanceToPlayer;
    
    void Start()
    {
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();
        colllectableTransform = this.gameObject.GetComponent<Transform>();

    }

    
    void Update()
    {
        distanceToPlayer = Vector3.Distance(playerTransform.position, colllectableTransform.position);
        Debug.Log(distanceToPlayer);
    }
}
