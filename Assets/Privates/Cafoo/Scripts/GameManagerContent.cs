using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerContent
{
    public static GameManagerContent instance;
    //�ϐ�
    public static int score;  //�X�R�A
    public static float limit; //�Q�[���^�C��
    public static float time;
    public static GameState gameState;
    //�]�T�������
    public static bool retryFlag;   //���g���C���ǂ����H
}
