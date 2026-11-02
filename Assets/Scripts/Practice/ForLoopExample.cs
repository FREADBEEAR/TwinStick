using JetBrains.Annotations;
using UnityEngine;

public class Practice : MonoBehaviour
{
    public int[] itemsToDrop;

    void Start()

    
    {
        itemsToDrop = new int[] { 1, 2, 3, 4, 5 };

        for (int i = 0; i < itemsToDrop.Length; i++)
        {

            Debug.Log($"the chest contains itemID: {itemsToDrop[i]}");

        }


    
    }

    
        
    
}
