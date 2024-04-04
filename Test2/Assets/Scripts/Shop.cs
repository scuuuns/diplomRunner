using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
[SerializeField] CoinManager _coinManager;
PlayerModifaer _playerModifaer;

private void Start(){
    _playerModifaer = FindObjectOfType<PlayerModifaer>();
    }
public void BuyWidth(){
    if (_coinManager.NumberOfCoin >=20){
        _coinManager.SpendMoney(20);
        Progress.Instance.Coins = _coinManager.NumberOfCoin;
        Progress.Instance.Width += 25;
        _playerModifaer.SetWidth(Progress.Instance.Width);
    }
}
public void BuyHeigth(){
    if (_coinManager.NumberOfCoin >=20){
         _coinManager.SpendMoney(20);
        Progress.Instance.Coins = _coinManager.NumberOfCoin;
        Progress.Instance.Height += 25;
        _playerModifaer.SetHeight(Progress.Instance.Height);
    }
}
}
