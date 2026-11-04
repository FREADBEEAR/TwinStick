using UnityEngine;
using UnityEngine.InputSystem;

public class PowerUpManager : MonoBehaviour
{
    
    private PowerUp[] powerups = new PowerUp[3];
    public int[] powerUpñount = new int[3];
    private PlayerHealth playerHealth;
    private PlayerMovement playerMovement;
    void Start()
    {

        playerHealth = GameObject.Find("Player").GetComponent<PlayerHealth>();
        Debug.Log("PlayerHealth found: " + (playerHealth != null));
        
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
        Debug.Log("PlayerMovement found: " + (playerMovement != null));



        powerups[0] = new PowerUp("Health Regeneration", 5);
        powerups[1] = new PowerUp("SpeedBoost",   10);
        powerups[2] = new PowerUp("Indomitable", 5);
    }
    void Update()
    {
        HandleCountdown();
        HandlePowerUpSelection();
        HandlePowerUpEffects();
    }

    private void HandleCountdown()
    {
        for (int i = 0; i < powerups.Length; i++)
        {
            if (powerups[i] != null)
            {
                if (powerups[i].isActive == true)
                {
                    powerups[i].Countdown();

                }


            }

        }
    }

    

    private void HandlePowerUpSelection()
    {
        if (Keyboard.current.digit1Key.wasPressedThisFrame)
            ActivatePowerUp(0);
        Debug.Log("Key 1 pressed!");

        if (Keyboard.current.digit2Key.wasPressedThisFrame)
            ActivatePowerUp(1);

        if (Keyboard.current.digit3Key.wasPressedThisFrame)
            ActivatePowerUp(2);


    }

    private void ActivatePowerUp(int powerUpIndex)
    {
        Debug.Log("PowerUp Count: " + powerUpñount[powerUpIndex]);

        if (powerups[powerUpIndex].isActive == false && powerUpñount[powerUpIndex] > 0)
        {
            powerups[powerUpIndex].isActive = true;
            Debug.Log(powerups[powerUpIndex].powerUpName + "is active");
            powerUpñount[powerUpIndex]--;
        }

    }

    private void HandlePowerUpEffects()
    {
        for (int i = 0; i < powerups.Length; i++)
        {
            switch (i)
            {
                case 0:

                    playerHealth.isRegenerating = powerups[i].isActive;
                    break;
                case 1:


                    playerHealth.isIndomitable = powerups[i].isActive;
                    break;

                case 2: 

                    playerMovement.isSpeeding = powerups[i].isActive;
                    
                    break;

               

                 default:
                    Debug.Log("No power up with index: " + i + "exists");

                    break;



            }

        }

    }



}
