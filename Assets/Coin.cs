using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
   // public AudioClip coin1;
    //public AudioClip coin2;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerStats playerStats = other.GetComponent<PlayerStats>();
            if(playerStats != null){
                playerStats.score++;
                Debug.Log("Score: " + playerStats.score);
            }
            //if(AudioManager.Instance != null)
           // {
            //    AudioManager.Instance.PlayRandomSFX(coin1,coin2);
            //}
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
