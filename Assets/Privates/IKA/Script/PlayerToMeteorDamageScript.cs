using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerToMeteorDamageScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Meteor")
        {
            Debug.Log(collision.gameObject.name);
            if (collision.gameObject.name == "meteorObjectORANGE" && this.gameObject.GetComponent<PlayerBulletScript>().Player.GetComponent<PlayerShotScript>().mainDirector.ColorInfoIndex == 0)
            {
                // this.gameObject.GetComponent<PlayerShotScript>().mainDirector.
                collision.gameObject.GetComponent<MeteorHP>().MeteorDamage(10);
            }
            if (collision.gameObject.name == "meteorObjectRED" && this.gameObject.GetComponent<PlayerBulletScript>().Player.GetComponent<PlayerShotScript>().mainDirector.ColorInfoIndex == 1)
            {
                // this.gameObject.GetComponent<PlayerShotScript>().mainDirector.
                collision.gameObject.GetComponent<MeteorHP>().MeteorDamage(10);
            }
            if (collision.gameObject.name == "meteorObjectGREEN" && this.gameObject.GetComponent<PlayerBulletScript>().Player.GetComponent<PlayerShotScript>().mainDirector.ColorInfoIndex == 2)
            {
                // this.gameObject.GetComponent<PlayerShotScript>().mainDirector.
                collision.gameObject.GetComponent<MeteorHP>().MeteorDamage(10);
            }

        }
    }
}
