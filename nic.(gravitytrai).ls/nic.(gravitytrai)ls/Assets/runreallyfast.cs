using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class runreallyfast : MonoBehaviour
{
    // "
    // The endermen in minecraft don't teleport they actually just run really, really fast
    // That's why they can't run over water
    // "
    
    // - Minecraft Combat Handbook
    // Circa. ~1,000,000 years ago

    public int enemies;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy").Length - 1; // 1 NME 'z unkillable but are there for decorat10n so just sub 2
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && enemies <= 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}
