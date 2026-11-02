using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{

    [SerializeField] private float delay;

    void Start()
    {
        Destroy(this.gameObject, delay);
    }


} 
