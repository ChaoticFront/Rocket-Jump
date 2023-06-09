using UnityEngine;
using UnityEngine.UI;

public class LevelCompleteUIManager : MonoBehaviour
{
    [SerializeField] private GameObject levelCompleteUI;
    [SerializeField] private Button nextLevelButton;
    [SerializeField] private LevelComplete levelComplete;
    private void Start()
    {
        // �������� ������ LevelCompleteUI ��� ������� �����
        levelCompleteUI.SetActive(false);

        // ������������� �������� ��� ������ nextLevelButton
        this.SetNextLevelButtonAction(() => levelComplete.LoadNextLevel());
    }

    public void ShowLevelCompleteUI()
    {
        // ���������� ������ LevelCompleteUI ����� ���������� �������� � ����������� �����
        levelCompleteUI.SetActive(true);
    }

    public void SetNextLevelButtonAction(System.Action action)
    {
        // ������������� �������� ��� ������ nextLevelButton
        nextLevelButton.onClick.AddListener(() => action.Invoke());
    }
}