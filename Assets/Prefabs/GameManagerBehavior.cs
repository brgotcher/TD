using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManagerBehavior : MonoBehaviour
{

    public bool gameOver = false;
    private int wave;
    public int Wave
    {
        get
        {
            return wave;
        }
        set
        {
            wave = value;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        Wave = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == true)
        { SceneManager.LoadScene("level2", LoadSceneMode.Single); }
    }
}
