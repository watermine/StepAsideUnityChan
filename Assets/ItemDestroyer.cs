using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour
{
    //Unityちゃんのオブジェクト
    private GameObject unitychan;
    //Unityちゃんとオブジェクトの距離
    private float difference;

    // Start is called before the first frame update
    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
        
    }

    // Update is called once per frame
    void Update()
    {
        //Unityちゃんとオブジェクトの位置（z座標）の差を求める
        this.difference = unitychan.transform.position.z - this.transform.position.z;

        //Unityちゃんとオブジェクトの位置（z座標）の差が一定になった際にオブジェクトを破棄
        if (this.difference > 10)
        {
            Destroy(this.gameObject);
        }
    }
}
