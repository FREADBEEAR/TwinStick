using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.InputSystem;

public class AbilityFiring : MonoBehaviour
{
    [SerializeField] private Ability ability;
    private AudioSource abilitySource;
    

    
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            GameObject projectile = Instantiate(ability.projectile, transform.position, transform.rotation);

            AudioManager.instance.Playclip(ability.shootsound);


            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * ability.speed, ForceMode.Impulse);

        }
    }

   
}
