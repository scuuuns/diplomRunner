using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class CoinManager : MonoBehaviour
{
    public int NumberOfCoin;
    [SerializeField]  TextMeshProUGUI _text;
    // Start is called before the first frame update
    
    private void Start(){
        NumberOfCoin = Progress.Instance.Coins;
        _text.text = NumberOfCoin.ToString();
    }
    public void AddOne()
    {
        NumberOfCoin++;
        _text.text = NumberOfCoin.ToString();
    }

    public void SaveToProgress(){
        Progress.Instance.Coins = NumberOfCoin;
    }

    public void SpendMoney(int value){
        NumberOfCoin -=value;
        _text.text = NumberOfCoin.ToString();
    }
}
