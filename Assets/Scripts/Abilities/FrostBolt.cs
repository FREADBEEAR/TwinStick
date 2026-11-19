using UnityEngine;
using UnityEngine.AI;

public class FrostBolt : Ability
{
    [SerializeField] private float slowSpeed = 2f;
    [SerializeField] private float slowDuration = 3f;

    protected override void ApplyEffect(GameObject target)
    {
        EnemyMovement enemyMovement = target.GetComponent<EnemyMovement>();

        if(enemyMovement != null)
        {
            slowSpeed = enemyMovement.MoveSpeed;
            enemyMovement.MoveSpeed = slowSpeed / 2f;
            slowDuration = 3f;



            return;
        }

       
    }
        



}
