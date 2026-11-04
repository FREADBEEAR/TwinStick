using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 20f;
    public float currentHealth;
    public bool isRegenerating = false;
    public bool isIndomitable = false;




    private void Start()
    {
        currentHealth = health;
    }


    private void Update()
    {

        currentHealth = Mathf.Clamp(currentHealth, 0, 100);
        Debug.Log(currentHealth);

        if (isRegenerating == true)
        {

            currentHealth += Time.deltaTime;
        }

        
    }
    public void TakeDamage(float damage)
    {
        if (isIndomitable == false)
        {

            currentHealth -= damage;
        }

    }


}
