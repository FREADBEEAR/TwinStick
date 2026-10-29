using UnityEngine;

public class WeaponPractiseManager : MonoBehaviour 
{
    public WeaponPractise Sword = new WeaponPractise(default,  "Sword");
    public WeaponPractise Axe = new WeaponPractise(20, "Axe");


    private void Start()
    {
        Sword.weapondamage += 10;
        Axe.weapondamage -= 5;
        Debug.Log(Sword.weaponName + ": " + Sword.weapondamage);
        Debug.Log(Axe.weaponName + ": " + Axe.weapondamage);
    }           

}
