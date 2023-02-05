using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

public class VirusPointUpdate : MonoBehaviour
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
        PaintTarget.TallyScore();
        this.transform.parent.gameObject.GetComponent<ContaminationRateScript>().SetContaminationPoint();
    }
}
