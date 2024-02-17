using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_Sene : MonoBehaviour
{
    public int Scene;

    public void GoToLevel(int number)
    {
        SceneManager.LoadScene(number);
    }
    public void Exit()
    {
        Application.Quit();
    }
}