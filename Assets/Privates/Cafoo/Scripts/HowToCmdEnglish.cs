using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToCmdEnglish : AbstractButton
{
    [SerializeField] GameObject Japanese;
    [SerializeField] GameObject English;

    public override void ItemClick()
    {
        base.ItemClick();

        Japanese.SetActive(false);
        English.SetActive(true);
    }
}
