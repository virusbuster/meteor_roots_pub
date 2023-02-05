using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintVirus : MonoBehaviour
{
    [SerializeField]
    Transform paintBallTran = null;

    [SerializeField]
   public float popRange = 0;
    [SerializeField]
    PaintVirus[] paintVirus = new PaintVirus[0];

    [SerializeField]
    List<Transform> paintBallList = new List<Transform>();


    [SerializeField]
    float rpeatTime = 2;
 
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CheckVirusPopPosition", 1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CheckVirusPopPosition()
    {
       
            float posX = this.transform.position.x + Random.Range(-popRange, popRange);
            float posZ = this.transform.position.z + Random.Range(-popRange, popRange);


            Vector3 v = new Vector3(posX, this.transform.position.y + 6, posZ);


            if (InSphere(this.transform.position, popRange * 5, v))
            {
                Debug.Log("”ÍˆÍ“à");
                paintBallTran.position = v;
            }
            else
            {
                Debug.Log("”ÍˆÍgai");
            }
        

    }

    public static bool InSphere(Vector3 p, float r, Vector3 c)
    {
        var sum = 0f;
        for (var i = 0; i < 3; i++)
            sum += Mathf.Pow(p[i] - c[i], 2);
        return sum <= Mathf.Pow(r, 2f);
    }
}
