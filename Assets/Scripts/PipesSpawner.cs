using UnityEngine;
using UnityEngine.UI;

public class PipesSpawner : MonoBehaviour
{
    public GameObject pipes;
    public Text score;

    float cooldown;

    readonly int pipesDestroyTimer = 4;

    void Start()
    {
        score = GameObject.Find("Score").GetComponent<Text>();
    }

    void Update()
    {
        Cooldown();
    }

    void Cooldown()
    {
        int convertedScore = int.Parse(score.text);

        if (cooldown <= 0)
        {
            Spawn();

            if (convertedScore >= 25 && convertedScore < 50)
            {
                cooldown = 2.5f;
            }
            else if (convertedScore >= 50 && convertedScore < 75)
            {
                cooldown = 2;
            }
            else if (convertedScore >= 75 && convertedScore < 100)
            {
                cooldown = 1.5f;
            }
            else if (convertedScore >= 100)
            {
                cooldown = 1;
            }
            else
            {
                cooldown = 3;
            }
        }
        else
        {
            cooldown -= Time.deltaTime;
        }
    }

    void Spawn()
    {
        GameObject pipesInstance = Instantiate(pipes, new Vector3(1.5f, Random.Range(3, 5), 0), Quaternion.identity);

        Destroy(pipesInstance, pipesDestroyTimer);
    }
}
