using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    private GameControllerScript gameController;

    //走り出しでUnityちゃんが着地したときgroundが反応するので
    //距離を取得し、最初の1mまで音を鳴らさないようにする
    private float speed = 5f;
    private float len = 0;

    //UnityChanのオブジェクト
    private GameObject unitychan;
    private GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject
            .FindWithTag("GameController")
            .GetComponent<GameControllerScript>();

        //UnityChanのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
    }


    void Update()
    {

    }


    //衝突時に呼ばれる関数
    void OnCollisionEnter2D(Collision2D collision)
    {
        //走り出しでUnityちゃんがgroundに設置したときに音がなってしまうので
        //最初の1ｍは音を鳴らさない条件を追加
        this.len += this.speed * Time.deltaTime;


        if ( ( tag != "UnityChan") && (len > 0.1))
        {
            
            switch (tag)
            {
                case "cube":
                    Debug.Log(tag);
                    gameController.AudioOn(1);
                    break;
                case "ground":
                    Debug.Log(tag);
                    gameController.AudioOn(2);
                    break;
                //case "UnityChan":
                    //Debug.Log(tag);
                    //gameController.AudioOn(3);
                    //break;
                default:
                    Debug.Log(tag);
                    //gameController.AudioOn(0.0f);
                    break;
            }
        }
    }
}
