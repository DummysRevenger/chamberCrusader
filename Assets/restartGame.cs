using UnityEngine;
using UnityEngine.SceneManagement;

public class restartGame : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ReloadScene();
        }
    }

    public static void ReloadScene()
    {
        
        SceneManager.LoadScene("characterSelect");
    }
}