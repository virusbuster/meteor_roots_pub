using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScripts : MonoBehaviour
{
    Vector2 LeftPos = new Vector2(-763.5582f, -379.2945f);
    Vector2 RightPos = new Vector2(321f, -379.2945f);

    [SerializeField] GameObject[] menuCursor;
    [SerializeField] GameObject[] menuButton;

    float invalidTImes = 0f;

    [SerializeField] int menuindex = 0;

    //GameState[] menuStr = { GameState.MainGame, GameState.HowTo, GameState.Credit};
    [SerializeField] string[] menuStr;

    GameObject gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager");

        MenuView();
    }

    // Update is called once per frame
    void Update()
    {
        invalidTImes += Time.deltaTime;
        if (invalidTImes <= 0.3f)
        {
            return;
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            if (menuindex > 0) menuindex--;


            invalidTImes = 0f;
            MenuView();
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            if (menuindex < menuCursor.Length - 1) menuindex++;

            invalidTImes = 0f;
            MenuView();
        }

        if (Input.GetKey(KeyCode.Return) )
        {
            //SceneManager.LoadScene(menuStr[menuindex]);

            menuButton[menuindex].GetComponent<AbstractButton>().ItemClick();
        }
    }

    public void MoveScene()
    {
        SceneManager.LoadScene(menuStr[menuindex]);
    }

    private void MenuView()
    {
        for(int i=0;i<menuCursor.Length;i++)
        {
            if (i == menuindex)
            {
                menuCursor[i].SetActive(true);
            }
            else
            {
                menuCursor[i].SetActive(false);
            }
        }
    }

    public int MenuIndex
    {
        set
        {
            menuindex = value;
            MenuView();
        }
        get
        {
            return menuindex;
        }
    }
}
