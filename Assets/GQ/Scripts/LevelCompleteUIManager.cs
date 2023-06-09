using UnityEngine;
using UnityEngine.UI;

public class LevelCompleteUIManager : MonoBehaviour
{
    [SerializeField] private GameObject levelCompleteUI;
    [SerializeField] private Button nextLevelButton;
    [SerializeField] private LevelComplete levelComplete;
    private void Start()
    {
        // Скрываем объект LevelCompleteUI при запуске сцены
        levelCompleteUI.SetActive(false);

        // Устанавливаем действие для кнопки nextLevelButton
        this.SetNextLevelButtonAction(() => levelComplete.LoadNextLevel());
    }

    public void ShowLevelCompleteUI()
    {
        // Показываем объект LevelCompleteUI после завершения анимации и отображения очков
        levelCompleteUI.SetActive(true);
    }

    public void SetNextLevelButtonAction(System.Action action)
    {
        // Устанавливаем действие для кнопки nextLevelButton
        nextLevelButton.onClick.AddListener(() => action.Invoke());
    }
}