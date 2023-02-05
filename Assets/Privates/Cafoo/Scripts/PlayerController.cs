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

    // �ʒm���󂯎�郁�\�b�h���́uOn + Action���v�ł���K�v������
    private void OnMove(InputValue value)
    {
        // MoveAction�̓��͒l���擾
        var axis = value.Get<Vector2>();

        // �ړ����x��ێ�
        _velocity = new Vector3(axis.x, 0, axis.y) * Speed;
    }

    //�V���b�g
    private void OnFire(InputValue value)
    {
     // if (gameObject.GetComponent<PlayerShotScript>().mainDirector.gameManager.GetComponent<GameManager>().GameState != GameState.MainGame) return;
        Debug.Log("Fire");
        gameObject.GetComponent<PlayerShotScript>().InstanceBullet();
    }

    //�ؑ�
    private void OnSwitch(InputValue value)
    {
   // if (gameObject.GetComponent<PlayerShotScript>().mainDirector.gameManager.GetComponent<GameManager>().GameState != GameState.MainGame) return;
        Debug.Log("SWitch");
        gameObject.GetComponent<PlayerShotScript>().mainDirector.ChangeBullet();
    }

    private void Update()
    {
        // �I�u�W�F�N�g�ړ�
        transform.position += _velocity * Time.deltaTime;

        //�΂�
        if (_velocity.x != 0 && _velocity.z != 0)
        {
            if (_velocity.x > 0 && _velocity.z > 0)
            {
                //�E�{�O
                PlayerObject.transform.rotation = Quaternion.Euler(0.0f, 45.0f, 0.0f);
            }
            else if (_velocity.x > 0 && _velocity.z < 0)
            {
                //�E�{��
                PlayerObject.transform.rotation = Quaternion.Euler(0.0f, 135.0f, 0.0f);
            }

            if (_velocity.x < 0 && _velocity.z > 0)
            {
                //���{�O
                PlayerObject.transform.rotation = Quaternion.Euler(0.0f, 315.0f, 0.0f);
            }
            else if (_velocity.x < 0 && _velocity.z < 0)
            {
                //���{��
                PlayerObject.transform.rotation = Quaternion.Euler(0.0f, 225.0f, 0.0f);
            }
        }
        else
        {
            //�����ݒ�
            if (_velocity.x > 0)
            {
                //�E
                PlayerObject.transform.rotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);
            }
            else if (_velocity.x < 0)
            {
                //��
                PlayerObject.transform.rotation = Quaternion.Euler(0.0f, 270.0f, 0.0f);
            }

            if (_velocity.z > 0)
            {
                //�O
                PlayerObject.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
            }
            else if (_velocity.z < 0)
            {
                //��
                PlayerObject.transform.rotation = Quaternion.Euler(0.0f, 180.0f, 0.0f);
            }
        }

        //�ړ����Ȃ�ړ��A�j���[�V����
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
