using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class ContaminationRateScript : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI contaminationText = null;

    private float contaminationPoint = 0;
    [SerializeField]
    GameManager gameManager;

    [SerializeField]
    GameObject gameoverObject;

    [SerializeField]
    Slider parsentSlider;

    public void SetContaminationPoint()
    {
        contaminationPoint = (PaintTarget.scores.x + PaintTarget.scores.y + PaintTarget.scores.z) * 100;
        parsentSlider.value = contaminationPoint;
        //メインsceneにゲームオーバーUIを表示
        if (contaminationPoint >= 100)
        {
           
            gameoverObject.SetActive(true);
        }

    }

    public void SetScore()
    {
        Debug.Log((int)parsentSlider.value);
        gameManager.GetScore = (int)parsentSlider.value;
    }


}
