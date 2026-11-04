using UnityEngine;
using UnityEngine.InputSystem;

public class PowerUpManager : MonoBehaviour
{
    
    private PowerUp[] powerups = new PowerUp[3];

    void Start()
    {
        
        powerups[0] = new PowerUp("Health Regeneration", 5);
        powerups[1] = new PowerUp("SpeedBoost",   10);
        powerups[2] = new PowerUp("Indomitable", 5);
    }
    void Update()
    {
        HandleCountdown();
        HandlePowerUpSelection();
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

        if (Keyboard.current.digit2Key.wasPressedThisFrame)
            ActivatePowerUp(1);

        if (Keyboard.current.digit3Key.wasPressedThisFrame)
            ActivatePowerUp(2);


    }

    private void ActivatePowerUp(int powerUpIndex)
    {

        if (powerups[powerUpIndex].isActive == false)
        {
            powerups[powerUpIndex].isActive = true;
            Debug.Log(powerups[powerUpIndex].powerUpName + "is active");
        }

    }

}
