using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{

    public AudioClip block;

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
                default:
                    break;
            }
        }
        
    }
}
