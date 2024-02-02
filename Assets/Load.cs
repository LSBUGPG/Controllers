using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    public string scene;

    public void LoadScene()
    {
        SceneManager.LoadScene(scene);
    }
}
