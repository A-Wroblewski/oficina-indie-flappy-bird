using UnityEngine;

public class BoundariesCollisions : MonoBehaviour
{
    public GameObject gameOver;

    private void OnTriggerEnter2D()
    {
        GameObject bird = GameObject.Find("Bird");

        bird.GetComponent<BirdMovement>().enabled = false;

        gameOver.SetActive(true);
    }
}
