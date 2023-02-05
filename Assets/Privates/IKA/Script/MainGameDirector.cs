using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class MainGameDirector : MonoBehaviour
{

    int bulletIndex = 0;
    int bossCount = 3;
    [SerializeField]
    private PaintVirus[] paintVirusscript = new PaintVirus[0];
    [SerializeField]
    private CollisionPainter[] collisonPainterscript = new CollisionPainter[0];
    [SerializeField]
    private string[] colorInfo = new string[0];
    private string nowcolorstr = "";
    int colorinfoIndex = 0;

    [SerializeField]
    TextMeshProUGUI magazineText = null;

    [SerializeField]
   private int[] colorBulletmagazine = new int[0];

    [SerializeField]
    Sprite[] bulletSprit = new Sprite[0];
    [SerializeField]
    Image BulletUIImage = null;


   public GameObject gameManager;

    //残弾追加　０オレンジ　１赤　２緑
    public void ReroadColorBullets(int bullets)
    {
        colorBulletmagazine[colorinfoIndex] += bullets;
        if (colorBulletmagazine[colorinfoIndex] > 0) GleenBulletUI();
            if (colorBulletmagazine[colorinfoIndex] >= 30) colorBulletmagazine[colorinfoIndex] = 30;
        magazineText.text = colorBulletmagazine[colorinfoIndex].ToString() + "/30";
    }

    public void BulletDecrease()
    {
        if (colorBulletmagazine[colorinfoIndex] < 0) return;
 
            colorBulletmagazine[colorinfoIndex] -= 1;
            if (colorBulletmagazine[colorinfoIndex] <= 0) EnptyBulletUI();
            magazineText.text = colorBulletmagazine[colorinfoIndex].ToString() + "/30";
        
    }

    public void EnptyBulletUI()
    {
        magazineText.color = new Color(180f / 255f, 0f / 255f, 0f / 255f);
    }
    public void GleenBulletUI()
    {
        magazineText.color = new Color(0f / 255f,255f / 255f, 0f / 255f);
    }

    public int GetUsingColorBulletMagazine()
    {
        return colorBulletmagazine[colorinfoIndex];
    }

    //現在設定している色弾　オレンジ→赤→緑
    public string GetColorInfo()
    {
      return  nowcolorstr;
    }


    // Start is called before the first frame update
    void Start()
    {
        
        nowcolorstr = colorInfo[0];
        magazineText.text = colorBulletmagazine[0].ToString() + "/30";
        gameManager = GameObject.Find("GameManager");
        gameManager.GetComponent<GameManager>().GameInit();
        //初期弾数設定
        for (int i=0;i< colorBulletmagazine.Length;i++)
        {
            colorBulletmagazine[i] = 30;
        }
    }
    public void EremiteMeteroCount()
    {
        bossCount--;
        for(int i = 0; i < paintVirusscript.Length; i++)
        {
            if (paintVirusscript[i] == null)
            {
                i++;
            }
            else
            {
                paintVirusscript[i].popRange = 30;
                collisonPainterscript[i].brush.splatScale = 12;
            }
        }
       
            if (bossCount <= 0)
        {
            Debug.Log("Call");
            this.gameObject.GetComponent<ContaminationRateScript>().SetScore();
            gameManager.GetComponent<GameManager>().GameEnd();
        }
    }
    public void ChangeBullet()
    {
        colorinfoIndex++;
        if(colorinfoIndex > 2) colorinfoIndex = 0;
        nowcolorstr = colorInfo[colorinfoIndex];
        magazineText.text = colorBulletmagazine[colorinfoIndex].ToString()+ "/30";

        //UIの変更
        BulletUIImage.sprite = bulletSprit[colorinfoIndex];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int ColorInfoIndex
    {
        get
        {
            return colorinfoIndex;
        }
    }

}
