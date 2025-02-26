using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void LoadNavigationScene()
    {
        SceneManager.LoadScene("NavigationScene"); // Change to your scene name
    }
}