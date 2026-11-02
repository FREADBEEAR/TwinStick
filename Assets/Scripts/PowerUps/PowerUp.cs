using UnityEngine;
using UnityEngine.Rendering;

public class PowerUp 
{

    public string powerUpName;
    public float durationSeconds;
    public bool isActive;
    private float originalDuration;


    public PowerUp() {}

    public PowerUp(string HealthRegeneration, float newdurationSeconds)
    { 
        powerUpName = HealthRegeneration;
        durationSeconds = newdurationSeconds;
        originalDuration = durationSeconds
    
    
    }
    public void Countdown()
    {
        isActive = true;
        durationSeconds -= Time.deltaTime;

        if (durationSeconds <=0)
        {
            durationSeconds = originalDuration;
            isActive =false;
            Debug.Log(powerUpName + "deactivated");
        }
    }



    
}
