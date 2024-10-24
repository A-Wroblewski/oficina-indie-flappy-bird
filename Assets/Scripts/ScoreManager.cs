using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text score;

    void Start()
    {
        score = GameObject.Find("Score").GetComponent<Text>();
    }

    private void OnTriggerEnter2D()
    {
        int convertedScore = int.Parse(score.text);

        convertedScore += 1;

        score.text = convertedScore.ToString();
    }
}
