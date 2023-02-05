using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletScript : MonoBehaviour
{
    [SerializeField]
    private float bulletSpeed = 0f;
    [SerializeField]
    private float bulletDedTime = 0;
    [SerializeField]
    private float bulletPowerRange = 1;

    [SerializeField]
    private GameObject player = null;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("BulletDestroy", bulletDedTime);
    }

    // Update is called once per frame
    void Update()
    {
        //ƒvƒŒƒCƒ„[‚©‚çˆê’è”ÍˆÍ‹‚È‚¢‚È‚çˆÚ“®
        if(((Vector3)(Player.transform.position - this.transform.position)).magnitude < 5)
        {
            transform.position += transform.forward * bulletSpeed * Time.deltaTime;
        }
    }

    void BulletDestroy()
    {
        Destroy(this.gameObject);
    }

    public GameObject Player
    {
        get
        {
            return player;
        }   
        set
        {
            player = value;
        }
    }


}
