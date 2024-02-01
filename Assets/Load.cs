using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    public SceneAsset scene;

    public void LoadScene()
    {
        SceneManager.LoadScene(scene.name);
    }
}
