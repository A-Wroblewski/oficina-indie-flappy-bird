using UnityEngine;

public class PipesMovement : MonoBehaviour
{
    readonly int speed = 2;

    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
    }
}
