using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;

    void Start()
    {
        gameOverPanel.SetActive(false);  // Verstecke das Panel zu Beginn
    }

    public void ShowGameOverScreen()
    {
        gameOverPanel.SetActive(true);  // Zeige das Game Over Panel an
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");  // Ersetze "MainMenu" durch den Namen deiner Hauptmenü-Szene
    }
}

