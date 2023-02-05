using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTween : MonoBehaviour
{
    [SerializeField]
    private float StartPosition = 0f;

    [SerializeField]
    private float EndPosition = 0f;

    // Start is called before the first frame update
    void Start()
    {
        iTween.MoveTo(this.gameObject,
            iTween.Hash(
                "y", StartPosition,
                "easeType", "easeOutBounce",
                "oncompletetarget", this.gameObject,
                "oncomplete", "EndAnimation"
                ));
    }

    void EndAnimation()
    {
        StartCoroutine("FinishAnim");
    }

    IEnumerator FinishAnim()
    {
        yield return new WaitForSeconds(3.0f);

        iTween.MoveTo(this.gameObject,
            iTween.Hash(
                "y", EndPosition,
                "easeType", "easeOutBounce"
                ));
    }
}
