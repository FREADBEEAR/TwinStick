using UnityEngine;

public class PowerUpManagerTest : MonoBehaviour
{
    public PowerUpTest Speed = new PowerUpTest(5, "Flow State");
    public PowerUpTest Strenght = new PowerUpTest(10, "Fury");
    

    public void Start()
    { 
        Speed.durationSeconds += 5;
        Strenght.durationSeconds -= 5;

        Debug.Log(Speed.PowerUpName + ": " + Speed.durationSeconds);
        Debug.Log(Strenght.PowerUpName + ": " + Strenght.durationSeconds);



    }


}
   

