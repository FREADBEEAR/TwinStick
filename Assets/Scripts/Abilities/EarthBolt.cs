using UnityEngine;

public class EarthBolt : Ability
{
    [SerializeField] private float RootSpeed = 0f;
    protected override void ApplyEffect(GameObject target)
    {
        EnemyMovement enemyMovement = target.GetComponent<EnemyMovement>();

        if (enemyMovement != null)
        {
            RootSpeed = enemyMovement.MoveSpeed;
            enemyMovement.MoveSpeed = RootSpeed = 0f;




            return;
        }


    }


}
