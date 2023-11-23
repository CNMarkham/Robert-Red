using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pick : MonoBehaviour
{
    public static GameObject Canvas;

    // Start is called before the first frame update
    void Start()
    {
        Canvas = GameObject.FindGameObjectWithTag("can");
        Canvas.SetActive(false);
    }

    public void x()
    {
        Application.Quit();
    }

    public void play()
    {
        if (SceneManager.GetActiveScene().name == "s1")
        {
            //Canvas.SetActive(false);
            return;
        }

        SceneManager.LoadScene("s1");
    }
}

    // Update is called once per frame
