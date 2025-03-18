using UnityEngine;
using TMPro;
public class CoinUI : MonoBehaviour
{
    [SerializeField]TextMeshProUGUI coinText;
    int currentCoin=0;

    public void AddCoin(int addAmount)
    {
        currentCoin += addAmount; //equal : currentCoin = currentCoin + addAmount;
        coinText.text = currentCoin.ToString();
    }
}
