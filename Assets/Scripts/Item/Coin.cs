using UnityEngine;

public class Coin : MonoBehaviour
{
    SoundEffectManager soundEffectManager;
    CoinUI coinUI;
    [SerializeField] int coinAmount;
    [SerializeField]AudioClip audioClip;

    void Start()
    {
        soundEffectManager = FindFirstObjectByType<SoundEffectManager>();
        coinUI = FindFirstObjectByType<CoinUI>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            soundEffectManager.PlaySound(audioClip);
            coinUI.AddCoin(coinAmount);
            Destroy(this.gameObject);
        }
    }
}
