using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreResultText;
    public AudioClip nextLevelMusic;
    private MusicManager musicManager;
    private LevelCompleteUIManager levelCompleteUIManager;
    private bool isNextLevelLoaded = false;

    private void Start()
    {
        musicManager = FindObjectOfType<MusicManager>();
        levelCompleteUIManager = FindObjectOfType<LevelCompleteUIManager>();
    }

    public void LoadNextLevel()
    {
        ResultScore resultScore = FindObjectOfType<ResultScore>();
        if (resultScore != null)
        {
            resultScore.ScoreResult();
        }

        Invoke("ShowLevelCompleteUI", 0.5f); // Показываем объект LevelCompleteUI с небольшой задержкой
    }

    private void ShowLevelCompleteUI()
    {
        levelCompleteUIManager.ShowLevelCompleteUI();
    }

    private void Update()
    {
        if (!isNextLevelLoaded && Input.GetKeyDown(KeyCode.Space))
        {
            isNextLevelLoaded = true;
            if (nextLevelMusic != null && musicManager != null)
            {
                musicManager.PlayNextLevelMusic(nextLevelMusic);
            }

            // Загрузить следующий уровень
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
