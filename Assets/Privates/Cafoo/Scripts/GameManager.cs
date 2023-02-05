using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    //変数
    [SerializeField] private int score = 0;  //スコア
    [SerializeField] private float limit = 0;  //汚染率：１００以下なら
    [SerializeField] private float time = 90; //ゲームタイム

    private float timeleft; //時間カウント用

    private GameState gameState = GameState.Opening; //状態管理 0:オープニング 1:メインゲーム 2:リザルト 3:クレジット

    private static GameManagerContent instance;

    private string mainScene = "IKAtestscene";

    private void Start()
    {
        if (instance == null)
        {
            instance = new GameManagerContent();
            GameManagerContent.score = 0;
            GameManagerContent.limit = 0;
            GameManagerContent.retryFlag = false;
            GameManagerContent.gameState = gameState;
        }

        this.score = GameManagerContent.score;
        this.limit = GameManagerContent.limit;
        this.gameState = GameManagerContent.gameState;
    }

    public void GameInit()
    {
        gameState = GameState.Opening;
        GameManagerContent.gameState = gameState;
    }

    public void GameStart()
    {
        score = 0;
        time = limit;
        GameManagerContent.time = limit;

        gameState = GameState.MainGame;
        GameManagerContent.gameState = gameState;
    }

    public void GameEnd()
    {
        GameManagerContent.retryFlag = false;
        gameState = GameState.Ending;
        //リザルト画面へ移動
        if (limit < 100)
        {
            SceneManager.LoadScene("Result");
        }
    }
    public void GameRetry()
    {
        GameManagerContent.retryFlag = true;
        SceneManager.LoadScene(mainScene);
    }

    private void Update()
    {
        //状態遷移
        if (gameState == GameState.Opening)
        {

        }
        else if (gameState == GameState.MainGame)
        {
            if (time < 0)
            {

                GameEnd();
            }
        }
        if (gameState == GameState.Ending)
        {

        }
    }

    public float TimeLimit
    {
        get
        {
            return limit;
        }
        set
        {
            limit = value;
            GameManagerContent.limit = limit;
        }
    }

    public float GameTime
    {
        get
        {
            return time;
        }
        set
        {
            time = value;
            GameManagerContent.time = time;
        }
    }

    public int GetScore
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
            GameManagerContent.score = score;
            Debug.Log("Score" + score.ToString());
        }
    }

    public GameState GameState
    {
        get
        {
            return gameState;
        }
    }

    public bool isRetry
    {
        get
        {
            return GameManagerContent.retryFlag;
        }
    }
}
