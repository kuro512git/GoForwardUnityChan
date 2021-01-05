using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    //キューブの移動速度
    private float speed = -12;

    //消滅位置
    private float deadLine = -10;


    //地面の位置
    private float groundLevel = -4.0f;

    //ブロックの衝突音
    public AudioClip block;
    AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        //画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    //衝突時に呼ばれる関数
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "UnityChan")
        {
            switch (collision.gameObject.tag)
            {
                case "cube":
                    Debug.Log(collision.gameObject.tag);
                    audioSource.Play(0);
                    break;
                case "ground":
                    Debug.Log(collision.gameObject.tag);
                    audioSource.Play(0);
                    break;
                default:
                    audioSource.UnPause();
                    break;
            }
            //以下の書き方では効果音が鳴らなかった
            //audioSource.PlayOneShot(block, 1F);
            //audioSource.volume = 1;
        }
    }
}
