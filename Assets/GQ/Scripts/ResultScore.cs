using TMPro;
using UnityEngine;

public class ResultScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreResultText;
    private bool isScoreSet = false;

    void Start()
    {
        ScoreResult();
    }

    public void ScoreResult()
    {
        if (!isScoreSet)
        {
            scoreResultText.text = Score.scoreValue.ToString();
            isScoreSet = true;
        }
    }
}