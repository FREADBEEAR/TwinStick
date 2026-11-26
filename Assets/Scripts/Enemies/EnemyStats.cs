using UnityEngine;

public struct EnemyStats 
{
    string EnemyName;
    float EnemyHealth;
    float EnemySpeed;
    float EnemyDamage;
    float EnemyAttackDistance;

    public EnemyStats(string eEame, float eHealth, float eSpeed, float eDamage, float eAttackDistance)
    {
        EnemyName = eEame;
        EnemyHealth = eHealth;
        EnemySpeed = eSpeed;
        EnemyDamage = eDamage;
        EnemyAttackDistance = eAttackDistance;

    }
}
