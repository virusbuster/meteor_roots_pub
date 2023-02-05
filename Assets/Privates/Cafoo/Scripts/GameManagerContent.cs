using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerContent
{
    public static GameManagerContent instance;
    //変数
    public static int score;  //スコア
    public static float limit; //ゲームタイム
    public static float time;
    public static GameState gameState;
    //余裕があれば
    public static bool retryFlag;   //リトライかどうか？
}
