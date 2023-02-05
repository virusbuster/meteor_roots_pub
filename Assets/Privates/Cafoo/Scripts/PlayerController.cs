using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float Speed = 1.0f;

    [SerializeField]
    private GameObject PlayerObject;

    private Vector3 _velocity;

    // 通知を受け取るメソッド名は「On + Action名」である必要がある
    private void OnMove(InputValue value)
    {
        // MoveActionの入力値を取得
        var axis = value.Get<Vector2>();

        // 移動速度を保持
        _velocity = new Vector3(axis.x, 0, axis.y) * Speed;
    }

    //ショット
    private void OnFire(InputValue value)
    {
     // if (gameObject.GetComponent<PlayerShotScript>().mainDirector.gameManager.GetComponent<GameManager>().GameState != GameState.MainGame) return;
        Debug.Log("Fire");
        gameObject.GetComponent<PlayerShotScript>().InstanceBullet();
    }

    //切替
    private void OnSwitch(InputValue value)
    {
   // if (gameObject.GetComponent<PlayerShotScript>().mainDirector.gameManager.GetComponent<GameManager>().GameState != GameState.MainGame) return;
        Debug.Log("SWitch");
        gameObject.GetComponent<PlayerShotScript>().mainDirector.ChangeBullet();
    }

    private void Update()
    {
        // オブジェクト移動
        transform.position += _velocity * Time.deltaTime;

        //斜め
        if (_velocity.x != 0 && _velocity.z != 0)
        {
            if (_velocity.x > 0 && _velocity.z > 0)
            {
                //右＋前
                PlayerObject.transform.rotation = Quaternion.Euler(0.0f, 45.0f, 0.0f);
            }
            else if (_velocity.x > 0 && _velocity.z < 0)
            {
                //右＋後
                PlayerObject.transform.rotation = Quaternion.Euler(0.0f, 135.0f, 0.0f);
            }

            if (_velocity.x < 0 && _velocity.z > 0)
            {
                //左＋前
                PlayerObject.transform.rotation = Quaternion.Euler(0.0f, 315.0f, 0.0f);
            }
            else if (_velocity.x < 0 && _velocity.z < 0)
            {
                //左＋後
                PlayerObject.transform.rotation = Quaternion.Euler(0.0f, 225.0f, 0.0f);
            }
        }
        else
        {
            //向き設定
            if (_velocity.x > 0)
            {
                //右
                PlayerObject.transform.rotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);
            }
            else if (_velocity.x < 0)
            {
                //左
                PlayerObject.transform.rotation = Quaternion.Euler(0.0f, 270.0f, 0.0f);
            }

            if (_velocity.z > 0)
            {
                //前
                PlayerObject.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
            }
            else if (_velocity.z < 0)
            {
                //後
                PlayerObject.transform.rotation = Quaternion.Euler(0.0f, 180.0f, 0.0f);
            }
        }

        //移動中なら移動アニメーション
        if (_velocity.x != 0 || _velocity.z != 0)
        {
            PlayerObject.GetComponent<Animator>().SetBool("Walk", true);
        }
        else
        {
            PlayerObject.GetComponent<Animator>().SetBool("Walk", false);
        }
    }
}
