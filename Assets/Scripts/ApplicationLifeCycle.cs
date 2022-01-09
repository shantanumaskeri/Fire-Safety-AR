using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplicationLifeCycle : MonoBehaviour
{
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

    public void ReloadScene()
	{
        SceneManager.LoadScene(0);
	}

}
