using UnityEngine;

public class Bow : Weapon
{
    protected override void Shoot()
    {
        Debug.Log("the player draws the bow back and holds");
    }
    
    private void Start()
    {
        Debug.Log("Custom bow shoot logic");
    }

    

   
}
