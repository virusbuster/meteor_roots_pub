using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectFire : MonoBehaviour
{
    [SerializeField]
    private GameObject effectPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void BurrelEffect()
    {
        //effectPrefab.GetComponent<ParticleSystem>()
        //GameObject target = GameObject.Instantiate(effectPrefab, new Vector3(this.transform.position.x, this.transform.position.y + 1.0f, this.transform.position.z), Quaternion.identity);
        //target.transform.Rotate(0, 90, 0, Space.World);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
