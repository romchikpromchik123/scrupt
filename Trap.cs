using UnityEditor.SceneManagement;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public string sceneName;

    void OnTriggerEnter(Collider other)
    {
        EditorSceneManager.LoadScene(sceneName);
    }

}
