using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShotScript : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletObject = null;
    [SerializeField]
    private Transform barrelTransform = null;

    [SerializeField]
    private GameObject berrelEffect = null;

    [SerializeField]
    private AudioSource ShotSE = null;

  
    public MainGameDirector mainDirector;

    GameObject gameDirector = null;

    private void Start()
    {
        gameDirector = GameObject.Find("GameData");
    }

    public void InstanceBullet()
    {
        if (mainDirector.GetUsingColorBulletMagazine() <= 0)
        {
            mainDirector.EnptyBulletUI();
            return;
        }
        mainDirector.BulletDecrease();
        GameObject burret = GameObject.Instantiate(bulletObject, barrelTransform.position, barrelTransform.rotation);
        burret.GetComponent<PlayerBulletScript>().Player = this.gameObject;

        burret.GetComponent<CollisionPainter>().playerBulletColorstr = mainDirector.GetColorInfo();

        GameObject target = GameObject.Instantiate(berrelEffect, barrelTransform.position, barrelTransform.rotation);
        target.transform.parent = this.gameObject.transform;

        if(gameDirector != null)
        {
            int colorindex = gameDirector.GetComponent<MainGameDirector>().ColorInfoIndex;
            if(colorindex == 0)
            {
                //ê¬
                ParticleSystem.MainModule par = target.GetComponent<ParticleSystem>().main;
                par.startColor = Color.blue;
            }
            else if(colorindex == 1)
            {
                //ê‘
                ParticleSystem.MainModule par = target.GetComponent<ParticleSystem>().main;
                par.startColor = Color.red;
            }
            else if(colorindex == 2)
            {
                //óŒ
                ParticleSystem.MainModule par = target.GetComponent<ParticleSystem>().main;
                par.startColor = Color.green;
            }

        }

        //SEçƒê∂
        ShotSE.Play();
    }

    private void Update()
    {
        
    }
}
