using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorHP : MonoBehaviour
{
    [SerializeField]
    private int meteorHelthPoint = 0;
    [SerializeField]
    private MainGameDirector gameDirector = null;

    [SerializeField]
    private GameObject EffectEnemyDie = null;

    [SerializeField]
    private GameObject HitEffect = null;

    bool isOneTime = false;

    public void MeteorDamage(int damePoint)
    {
        meteorHelthPoint -= damePoint;
        StartCoroutine("HitEffectProc");
        if (meteorHelthPoint <= 0 && !isOneTime)
        {
            isOneTime = true;
            gameDirector.EremiteMeteroCount();

            StartCoroutine("DestroyEffect");
        }
    }

    IEnumerator HitEffectProc()
    {
        GameObject obj = GameObject.Instantiate(HitEffect, this.transform);
        obj.transform.localPosition = new Vector3(0, 0, 0);

        yield return null;
    }

    IEnumerator DestroyEffect()
    {
        GameObject obj = GameObject.Instantiate(EffectEnemyDie, this.transform);
        obj.transform.localPosition = new Vector3(0, 0, 0);

        yield return new WaitForSeconds(1.0f);
        Destroy(this.gameObject);
    }
}
