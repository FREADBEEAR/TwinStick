using UnityEngine;

public abstract class Ability : MonoBehaviour
{
    public GameObject projectile;
    public float speed;
    [SerializeField] private float damage;
    private bool hasHitEnemy;
    [SerializeField] private float Health = 100f;

    

    private bool ApplyDamage(GameObject target)
    {

       


        EnemyBlob enemyBlob = target.GetComponent<EnemyBlob>();

        if (enemyBlob != null)
        {
            enemyBlob.TakeDamage(damage);

            return true;
        }

        return false;

    }
    
        
    protected virtual void ApplyEffect(GameObject target)
    {

    }

    private void TakeDamage(float damageAmount)
    {
        Health -= damageAmount;
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (hasHitEnemy == true)
        {
            return;

        }


        bool damageApplied  = ApplyDamage(other.gameObject);

        if (damageApplied == true)
        {
            hasHitEnemy = true;
            ApplyEffect(other.gameObject);
            Destroy(gameObject);
        }



    }
}
