using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class life : MonoBehaviour
{
    public int lifes;
    public bool winner;
    public bool winnerwinner;
    public bool l2;
    public MouseManager ma;
    public TextMeshProUGUI text;

    public string heart;
    public static life f;

    public bool st;
    string hearts(int x)
    {
        var h = "";

        for (int y=0; y<x; y++)
        {
            h += heart + " ";
        }

        return h;
    }

    // Start is called before the first frame update
    void Start()
    {
        heart = "<3";
        text.text = hearts(lifes);
        f = this;
    }

    public void remlif() { lifes -= 1; }
    void addlif() { lifes += 1; }

    public void win() 
    {
        ma.blah = true;
        winner = true;
        if (SceneManager.GetActiveScene().name == "s2")
        {
            winnerwinner = true;
            return;
            
        }

        Invoke("b", 2);
    }

        private void b()
    {
        ma.blah = false;
        winner = false;
        if (!l2) SceneManager.LoadScene("s2");
        l2 = true;

    }

    // Update is called once per frame
    void Update()
    {
        text.text = hearts(lifes);

        if (lifes == 0)
        {
            text.text = "loser";

        }

        if (winner == true) { 
            text.text = "Winner";
        }

        if (winnerwinner == true)
        {
            text.text = "WINNNERR";
            ma.blah = true;
        }
    }
}
