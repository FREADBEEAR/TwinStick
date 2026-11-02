using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Vector3 MoveDirection;
    [SerializeField] private float MoveSpeed;
    



    void Start()
    {

    }


    void Update()
    {
        transform.Translate(MoveDirection * Time.deltaTime * MoveSpeed, Space.World);
        

    }

    private void OnCollisionEnter(Collision other)
    {
        
        MoveDirection = Vector3.Reflect (
            MoveDirection, other.GetContact(0).normal);

        



    }
    

    

}

   