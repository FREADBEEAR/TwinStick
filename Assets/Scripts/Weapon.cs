using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] protected  string weaponName;
    [SerializeField] protected  int weaponAmmo;
    protected virtual void Shoot()
    {

        Debug.Log("Default shooting behavior for " + weaponName);
    }


    private void Attack()
    {
        if (weaponAmmo > 0)
        {
            weaponAmmo--;
            Shoot();
        }
        else
        {
            Debug.Log("No ammo left for " + weaponName);
        }
    }

    
}
