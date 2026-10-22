using UnityEngine;

public class WhileLoopExample : MonoBehaviour
{
    public int MonsterHealth = 100;
    public int playerDamage = 0;
    void Start()
    {
        while (MonsterHealth > 0)
        {
            playerDamage = Random.Range(1, 16);
            MonsterHealth -= playerDamage;
            Debug.Log($"Player dealt {playerDamage} damage. Monster health is now {MonsterHealth}");
        }
        Debug.Log($"monster is defeated");
    }

}
