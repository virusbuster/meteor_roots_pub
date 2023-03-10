using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTarget : MonoBehaviour
{
    [SerializeField]
    [Tooltip("追従させたいターゲット")]
    private GameObject target;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        // ゲーム開始時点のカメラとターゲットの距離(オフセット)を取得
        offset = gameObject.transform.position - target.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // カメラの位置をターゲットの位置にオフセットを足した場所にする。
        gameObject.transform.position = target.transform.position + offset;
    }
}
