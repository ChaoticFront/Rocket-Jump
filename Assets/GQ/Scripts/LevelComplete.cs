using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreResultText;
      
    public void LoadNextLevel()
    {
        ResultScore resultScore = FindObjectOfType<ResultScore>();
        if (resultScore != null)
        {
            resultScore.ScoreResult();
        }

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}