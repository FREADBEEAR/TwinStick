using UnityEngine;

public class FunctionExample : MonoBehaviour
{
    public int TotalCoins = 0;
    private void Start()
    {
        TakeDamage(5);
        CollectCoins(1);
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

}
