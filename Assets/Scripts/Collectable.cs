using UnityEngine;

public class Collectable : MonoBehaviour
{
    Transform playerTransform;
    Transform colllectableTransform;
    float distanceToPlayer;
    private Score scoreRef;
    
    void Start()
    {
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();
        colllectableTransform = this.gameObject.GetComponent<Transform>();
        scoreRef = GameObject.Find("ScoreManager").GetComponent<Score>();
        
    }

    
    void Update()
    {
        distanceToPlayer = Vector3.Distance(playerTransform.position, colllectableTransform.position);
        


        if (distanceToPlayer <= 5)
        {

            scoreRef.score++;
            GameObject.Destroy(colllectableTransform.gameObject);
            
            
        }

        
    }
}
