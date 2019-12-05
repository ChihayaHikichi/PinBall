using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PointController : MonoBehaviour
{
    // ポイント
    private int Point = 0;

    // 点数を表示するテキスト
    private GameObject PointText;

    // Use this for initialization
    void Start()
    {
        // シーン中のGameOverTextオブジェクトを取得
        this.PointText = GameObject.Find("PointText");
    }

    // Update is called once per frame
    void Update()
    {



        // 点数をを表示
        //this.PointText.GetComponent<Text>().text = "得点：" + Point;
        
    }

    // 衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {
        // タグによって点数を変える
        if (other.gameObject.tag == "SmallStarTag")
        {
            this.Point += 10;
            //Debug.Log("小星");
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            this.Point += 30;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            this.Point += 20;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            this.Point += 40;
        }

        //Debug.Log("衝突");
        // 点数をを表示
        this.PointText.GetComponent<Text>().text = "得点：" + Point;

    }


}