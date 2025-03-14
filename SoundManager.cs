using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource src;
    public AudioSource MainMusic;
    public AudioClip MainMusicClip;
    public AudioClip ClickSound;
    public AudioClip CantBuy;
    public AudioClip Buying;

    private void Start() {
        MainMusic.loop = true;
        MainMusic.clip = MainMusicClip;
        MainMusic.Play();
    }

    public void PlayButtonSound(){
        src.pitch = Random.Range(1f, 3f);
        src.clip = ClickSound;        
        src.Play();
    }

    public void CantBuyItem() {
        src.clip = CantBuy;        
        src.Play();
    }

    public void BuyingItem() {       
            src.clip = Buying;
             src.Play();
    }

    public void CheckForWhichSoundToPlay(){
        if(MoneyManager.MoneyChecker(MoneyManager.CostOfButtonOne)){
                BuyingItem();
        }
        else{
                CantBuyItem();
        }
    }
}
