using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTarget : MonoBehaviour
{
    [SerializeField]
    [Tooltip("�Ǐ]���������^�[�Q�b�g")]
    private GameObject target;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        // �Q�[���J�n���_�̃J�����ƃ^�[�Q�b�g�̋���(�I�t�Z�b�g)���擾
        offset = gameObject.transform.position - target.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // �J�����̈ʒu���^�[�Q�b�g�̈ʒu�ɃI�t�Z�b�g�𑫂����ꏊ�ɂ���B
        gameObject.transform.position = target.transform.position + offset;
    }
}
