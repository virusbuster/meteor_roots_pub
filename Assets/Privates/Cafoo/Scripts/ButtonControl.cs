using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : AbstractButton
{
    public override void ItemClick()
    {
        if (menuscript == null) return;

        menuscript.GetComponent<MenuScripts>().MoveScene();
    }

}
