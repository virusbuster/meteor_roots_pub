using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractButton : MonoBehaviour
{
    [SerializeField] protected GameObject menuscript;
    [SerializeField] protected int menuIndex;

    public void CursorOn()
    {
        if (menuscript == null) return;

        //GameObject obj = (GameObject)Resources.Load("ButtonFocusSound");
        //GameObject instance = (GameObject)Instantiate(obj,
        //                                      new Vector3(0.0f, 0.0f, 0.0f),
        //                                      Quaternion.identity);
        //instance.GetComponent<AudioSource>().Play();

        menuscript.GetComponent<MenuScripts>().MenuIndex = menuIndex;
    }

    public void CursorOff()
    {
        if (menuscript == null) return;

        menuscript.GetComponent<MenuScripts>().MenuIndex = -1;
    }
    public virtual void ItemClick()
    {
    }
}
