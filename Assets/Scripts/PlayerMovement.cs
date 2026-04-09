using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float Speed = GameParameters.PlayerSpeed;
    public Rigidbody2D RigidBody;
    public Animator Animator;

    private object priorityDevice = null;



    public void Move(Vector2 direction, object inputDevice)
    {
        SetPriorityInputDevice(direction, inputDevice);
        
        // Animator
        ApplyMovement(direction);
    }

    private void SetPriorityInputDevice(Vector2 direction, object inputDevice)
    {
        if (IsMoving(direction))
        {
            priorityDevice = inputDevice;
        }
    }

    private bool IsMoving(Vector2 direction)
    {
        return direction != Vector2.zero;
    }

    private void ApplyMovement(Vector2 direction)
    {
        RigidBody.linearVelocity = direction * Speed;
    }
}
