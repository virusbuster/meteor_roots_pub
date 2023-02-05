using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.InputSystem;

public class GameStartEvent : MonoBehaviour
{
    [SerializeField]
    GameObject radyTextObject = null;
    [SerializeField]
    GameObject GoTextObject = null;

    [SerializeField]
    GameObject maincameraobject = null;
    [SerializeField]
    GameManager gameManager;

    [SerializeField]
    GameObject playerObject;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("FastCameraWork",1);
    }

    void FastCameraWork()
    {
        maincameraobject.transform.DOMove(new Vector3(0.5f, 9.8f, -93f), 2f).SetEase(Ease.InOutQuart);
        Invoke("SecondCameraWork", 2);
    }

    void SecondCameraWork()
    {
        maincameraobject.transform.DOMove(new Vector3(0f, 14, -82f), 2f);
        maincameraobject.transform.DORotate(new Vector3(36, 0, 0), 1f);
        Invoke("RedyPop", 2f);
    }

    void RedyPop()
    {

        radyTextObject.SetActive(true) ;
        radyTextObject.transform.DOScale(new Vector3(2, 2, 2), 1);


        Invoke("Startgame", 1.5f);

    }

    void Startgame()
    {
        radyTextObject.SetActive(false);
        GoTextObject.SetActive(true);
        GoTextObject.transform.DOScale(new Vector3(2, 2, 2), 1);
        playerObject.GetComponent<PlayerInput>().enabled = true;
        playerObject.GetComponent<PlayerShotScript>().enabled = true;
        maincameraobject.gameObject.GetComponent<CameraTarget>().enabled = true;
        Invoke("EvenrEnd", 0.5f);
    }

    void EvenrEnd()
    {
        GoTextObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
