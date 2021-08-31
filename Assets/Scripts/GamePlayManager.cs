using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayManager : Singleton<GamePlayManager>
{
    public int RightPoints
    {
        get { return rightPoints;  }
        set
        {
            rightPoints = value;
            HUD.UpdateRightPoints(rightPoints);
        }
    }
    public int LeftPoints
    {
        get { return leftPoints; }
        set
        {
            leftPoints = value;
            HUD.UpdateLeftPoints(leftPoints);
        }
    }

    private int rightPoints;
    private int leftPoints;
    private HUDController HUD;

    private void Start()
    {
        HUD = FindObjectOfType<HUDController>();

        RightPoints = 0;
        LeftPoints = 0;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

}
