using UnityEngine;
using UnityEngine.SceneManagement;

public class RESTART : MonoBehaviour
{
    // Цей метод викликається при натисканні кнопки
    public void RestartGame()
    {
        // Отримуємо назву поточної сцени
        string currentSceneName = SceneManager.GetActiveScene().name;

        // Перезавантажуємо цю сцену
        SceneManager.LoadScene(currentSceneName);

        // Відновлюємо час на випадок, якщо він був зупинений
        Time.timeScale = 1f;
    }
}
