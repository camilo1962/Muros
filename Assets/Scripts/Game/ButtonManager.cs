using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameManager.Instance;
    }

    public void TryAgainButton()
    {
        Fades.LoadScene(0);
    }

    public void PauseButton()
    {
        gameManager.SetPageState(GameManager.PageState.Pause);
        Time.timeScale = 0;
    }

    public void ContinueButton()
    {
        Time.timeScale = 1;
        gameManager.SetPageState(GameManager.PageState.None);
    }
    public void Salir()
    {
        Application.Quit();
    }
    public void OtroButton()
    {
        Fades.LoadScene(1);
    }

    public void Volver(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
}
