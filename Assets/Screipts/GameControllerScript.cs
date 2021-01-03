using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{

    [SerializeField] public AudioClip block;
    [SerializeField] public AudioClip oops;
    AudioSource audioSource;

    private int tagx = 0;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AudioOn(int tagx)
    {
        Debug.Log(tagx);
        if (tagx > 0)
        {

            switch (tagx)
            {
                case 1:
                    Debug.Log(tagx);
                    audioSource.PlayOneShot(block, 0.8F);
                    break;
                case 2:
                    Debug.Log(tagx);
                    audioSource.PlayOneShot(block, 0.3F);
                    break;
                case 3:
                    Debug.Log(tagx);
                    //audioSource.PlayOneShot(oops, 0.7F);
                    break;
                default:
                    break;
            }
        }
        /*
       switch (tagx)
       {

           case "cube":
               //vlm = 0.8F;
               //Debug.Log(tagx);
               audioSource.PlayOneShot(block, 0.8F);
               break;
           case "ground":
               //vlm = 0.3F;
               //Debug.Log(tagx);
               audioSource.PlayOneShot(block, 0.3F);
               break;
           case "UnityChan":
               //Debug.Log(tagx);
               //audioSource.PlayOneShot(block, 0.0F);
               break;
           default:
               //gameController.AudioOn(0.0f);
               break;
       }
       //ブロックが衝突したらボリュームをあげる
       //Debug.Log(vlm);
       //audioSource.PlayOneShot(block, vlm);
           */
    }
}
