using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    readonly int force = 6;

    Rigidbody2D rigidBody2D;

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Jump();
    }

    void Jump()
    {
        bool pressedSpaceKey = Input.GetKeyDown(KeyCode.Space);

        if (pressedSpaceKey)
        {
            rigidBody2D.velocity = Vector2.zero;
            rigidBody2D.AddForce(Vector2.up * force, ForceMode2D.Impulse);
        }
    }
}
