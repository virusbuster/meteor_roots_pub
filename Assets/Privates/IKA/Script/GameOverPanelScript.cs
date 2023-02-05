using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine;

public class GameOverPanelScript : MonoBehaviour
{
    [SerializeField]
    private Image gameoverpanel=null;
    [SerializeField]
    private Image titleButton = null;

  
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       if(gameoverpanel.IsActive()) gameoverpanel.DOFade(0.85f, 2);
    }
}
