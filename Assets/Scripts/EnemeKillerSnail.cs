using UnityEngine;
using UnityEngine.AI;


public class EnemeKillerSnale : MonoBehaviour
{
    NavMeshAgent agent;
    private Transform playerTransform;
    private PlayerHealth playerHealth;
    [SerializeField] private float attackDistamce = 5f;
    private bool isIndomitable;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        playerTransform = GameObject.Find("Player").transform.GetComponent<Transform>();
        playerHealth = GameObject.Find("Player").GetComponent<PlayerHealth>();
        isIndomitable = GameObject.Find("Player").GetComponent<PlayerHealth>().isIndomitable;

    }

    private float DistanceToTarget()
    {
        float distanceToPlayer = Vector3.Distance(playerTransform.position, this.transform.position);

        return distanceToPlayer;



    }
    
    void Update()
    {
        agent.SetDestination(playerTransform.position);
        float distanceToPlayer = DistanceToTarget();

        if (distanceToPlayer <= attackDistamce && isIndomitable == false)
        {
           agent.isStopped = true;
            playerHealth.currentHealth = 0;


        }
        else
        {
            agent.isStopped = false;
            
        }

    }
}
