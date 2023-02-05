using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    //�ϐ�
    [SerializeField] private int score = 0;  //�X�R�A
    [SerializeField] private float limit = 0;  //�������F�P�O�O�ȉ��Ȃ�
    [SerializeField] private float time = 90; //�Q�[���^�C��

    private float timeleft; //���ԃJ�E���g�p

    private GameState gameState = GameState.Opening; //��ԊǗ� 0:�I�[�v�j���O 1:���C���Q�[�� 2:���U���g 3:�N���W�b�g

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
        //���U���g��ʂֈړ�
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
        //��ԑJ��
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
