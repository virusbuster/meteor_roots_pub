using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastColorGetScript : MonoBehaviour
{
    
 
   public void PlayerToUnderColor()
    {



        //// Rayを飛ばす（第1引数がRayの発射座標、第2引数がRayの向き）
        //Ray ray = new Ray(transform.position, -transform.up);

        //// outパラメータ用に、Rayのヒット情報を取得するための変数を用意
        //RaycastHit hit;

        //// シーンビューにRayを可視化するデバッグ（必要がなければ消してOK）
        //Debug.DrawRay(ray.origin, ray.direction * 30.0f, Color.red, 0.0f);

        //// Rayのhit情報を取得する
        //if (Physics.Raycast(ray, out hit, 30.0f))
        //{

        //    // Rayがhitしたオブジェクトのタグ名を取得
        //    string hitTag = hit.collider.tag;

        //    // タグの名前がEnemyだったら、照準の色が変わる
        //    if ((hitTag.Equals("Map")))
        //    {
        //        Renderer r = hit.transform.GetComponent<Renderer>();
        //             Texture2D tc = r.;
        //    }
        //    else
        //    {
        //        // Enemy以外では水色に
        //        aimPointImage.color = new Color(0.0f, 1.0f, 1.0f, 1.0f);
        //    }

        //}
        


    }
}
