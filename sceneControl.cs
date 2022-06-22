using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    // Start is called before the first frame update
    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void Home()
    {
        SceneManager.LoadScene("HomeScreen");
    }
}
