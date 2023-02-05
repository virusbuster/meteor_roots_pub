using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToCmdJapanese : AbstractButton
{
    [SerializeField] GameObject Japanese;
    [SerializeField] GameObject English;

    public override void ItemClick()
    {
        base.ItemClick();

        Japanese.SetActive(true);
        English.SetActive(false);
    }

}
