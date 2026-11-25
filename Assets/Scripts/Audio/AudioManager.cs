using UnityEngine;
using UnityEngine.Rendering;

public class AudioManager : MonoBehaviour
{


    [SerializeField] private AudioSource audioSource;
    public static AudioManager instance;
    void Awake()
    {
        if(instance != null)
        {
            if(instance !=this)
            {
                Destroy(this);
                return;

            }


        }


        instance = this;
        DontDestroyOnLoad(instance);
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Playclip(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);

    }
    

    void Update()
    {
        
    }
}
