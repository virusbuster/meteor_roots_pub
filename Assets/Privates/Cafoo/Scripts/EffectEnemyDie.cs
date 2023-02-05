using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectEnemyDie : MonoBehaviour
{
    [SerializeField]
    private GameObject effectEnemyDie;

    [SerializeField]
    private GameObject effectExplotion;

    [SerializeField]
    private GameObject effectBomb;

    [SerializeField]
    private AudioSource SEexplotion;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("EnemyDie");
    }

    public void StartEffect()
    {
        StartCoroutine("EnemyDie");
    }
    IEnumerator EnemyDie()
    {
        SEexplotion.Play();

        GameObject.Instantiate(effectExplotion, this.transform);

        yield return new WaitForSeconds(0.3f);
        GameObject.Instantiate( effectBomb, new Vector3( this.transform.position.x, this.transform.position.y + 3.0f, this.transform.position.z ),Quaternion.identity );

        yield return new WaitForSeconds(0.3f);

        GameObject.Instantiate(effectEnemyDie, this.transform);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
