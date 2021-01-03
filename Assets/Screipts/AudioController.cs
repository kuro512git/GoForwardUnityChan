using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    private GameControllerScript gameController;

    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject
            .FindWithTag("GameController")
            .GetComponent<GameControllerScript>();
    }


    void Update()
    {

    }


    //衝突時に呼ばれる関数
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        ///if(tag != "UnityChan")
        //{
            
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
                case "UnityChan":
                    Debug.Log(tag);
                    gameController.AudioOn(3);
                    break;
                default:
                    Debug.Log(tag);
                    //gameController.AudioOn(0.0f);
                    break;
            }
        //}
    }
}
