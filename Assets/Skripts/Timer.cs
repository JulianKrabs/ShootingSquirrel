using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float initialTime = 60f;  // Startzeit des Timers
    private float remainingTime;
    private bool isGameOver = false;
    public GameOverScreen gameOverScreen;  // Referenz zum GameOverScreen-Skript

    void Start()
    {
        remainingTime = initialTime;
        if (gameOverScreen != null)
        {
            gameOverScreen.gameObject.SetActive(false);  // Verstecke das Game Over Panel zu Beginn
        }
    }

    void Update()
    {
        if (!isGameOver)
        {
            remainingTime -= Time.deltaTime;
            int minutes = Mathf.FloorToInt(remainingTime / 60);
            int seconds = Mathf.FloorToInt(remainingTime % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

            if (remainingTime <= 0)
            {
                remainingTime = 0;
                GameOver();
            }
        }
    }

    void GameOver()
    {
        isGameOver = true;
        timerText.text = "00:00";
        if (gameOverScreen != null)
        {
            gameOverScreen.ShowGameOverScreen();  // Zeige das Game Over Panel an
        }
        DisablePlayerInput();
    }

    void DisablePlayerInput()
    {
        // Hier kannst du die Eingaben deaktivieren
        // Zum Beispiel durch Setzen eines Flags oder Deaktivieren von GameObjects
    }
}

