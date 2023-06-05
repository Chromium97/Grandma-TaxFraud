using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{

    [SerializeField] GameObject gameOverScreen;
    [SerializeField] Text score;
    [SerializeField] Text aliveTime;
    public GameController game;

    public void SetGameOverScreen()
    {
        gameOverScreen.SetActive(true);

        score.text = "Your Score: " + game.token.ToString();
        aliveTime.text ="Time Spent Avoiding Taxes" + game.timeAlive.ToString();
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
