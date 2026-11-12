using UnityEngine;

public abstract class Ability : MonoBehaviour
{
    public GameObject projectile;
    public float speed;
    [SerializeField] private float damage;
    private bool hasHitEnemy;
    [SerializeField] private float Health = 100f;

    private void OnTriggerEnter(Collider other)
    {
        
    }

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

}
