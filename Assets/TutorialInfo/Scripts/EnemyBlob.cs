using System;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyBlob : MonoBehaviour
{
     Transform playerTransform;
     Transform enemytransform;

    float damage = 2f;
    float distanceToPlayer;
    [ SerializeField]  private float minimumDamageDistance = 5;
    public PlayerHealth healthRef;
    [SerializeField] private GameObject explosionEffect;


    void Start()
    {
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();
        enemytransform = this.gameObject.GetComponent<Transform>();
        healthRef = GameObject.Find("Player").GetComponent<PlayerHealth>();



    }

    void Update()
    {
        distanceToPlayer = Vector3.Distance(playerTransform.position, enemytransform.position);


        if (distanceToPlayer < minimumDamageDistance)


        {
            explosionEffect.transform.parent = null;
            explosionEffect.SetActive(true);
            GameObject.Destroy(enemytransform.gameObject);
            healthRef.currentHealth = healthRef.currentHealth - damage;

        }

        
    }
}
