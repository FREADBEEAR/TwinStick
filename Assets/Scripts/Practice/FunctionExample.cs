using UnityEngine;

public class FunctionExample : MonoBehaviour
{
    public int TotalCoins = 0;
    private void Start()
    {
        TakeDamage(5);
        CollectCoins(1);
        CalculateHealth(10,5);
        int result = CollectCoins(1);
        Debug.Log($"Total coins collected: {result}");
    }

    void TakeDamage(int damage)
    {
        Debug.Log($"Player took {damage} damage");
    }

    private int CollectCoins(int coins)
    {
        int result = coins + TotalCoins;
        return result;
    }

    private int CalculateHealth(int health, int damage)
    {
        int result = health - damage;
        return result;
    }
}
