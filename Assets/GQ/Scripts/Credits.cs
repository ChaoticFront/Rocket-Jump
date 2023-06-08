using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("QUIT");
       Application.Quit();
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0); // Загружаем сцену с индексом 0 (первый уровень)
    }
}
