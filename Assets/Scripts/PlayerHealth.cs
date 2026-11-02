using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 20f;
    public float currentHealth;




    private void Start()
    {
        health = currentHealth;
    }


    private void Update()
    {
        Debug.Log(currentHealth);
    }


}
