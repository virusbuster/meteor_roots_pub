using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ContamiController : MonoBehaviour
{
    [SerializeField]
    private Slider slider = null;

    [SerializeField]
    private Image fill = null;

    [SerializeField]
    private TextMeshProUGUI text = null;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        if(slider.value > 50)
        {
            fill.color = Color.red;
            text.color = Color.red;
        }
        else
        {
            fill.color = Color.green;
            text.color = Color.green;
        }
    }
}
