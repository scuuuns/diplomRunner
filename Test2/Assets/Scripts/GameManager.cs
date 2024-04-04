using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField] GameObject _startMenu;
    
    [SerializeField] TextMeshProUGUI _levelText;
    [SerializeField] GameObject _finishWindow;
    [SerializeField] GameObject _replayWindow;
    //[SerializeField] GameObject _endWindow;
    [SerializeField] CoinManager _coinManager;

    private void Start ()
    {
      _levelText.text = SceneManager.GetActiveScene().name;
    }
 
  public void Play () {
        _startMenu.SetActive(false);
        FindObjectOfType<PlayerBehavior>().Play();
  }
  
  public void ShowFinishWindow () {
      _finishWindow.SetActive(true);
  }
  public void NextLevel () {
    int next = SceneManager.GetActiveScene().buildIndex + 1;
    if (next < SceneManager.sceneCountInBuildSettings){
      _coinManager.SaveToProgress();
        SceneManager.LoadScene(next);
    }

  }
     public void ShowReplayWindow () {
      _replayWindow.SetActive(true);
  }
    public void ReplayLevel () {
    int next = SceneManager.GetActiveScene().buildIndex + 1;
    if (next < SceneManager.sceneCountInBuildSettings){
      _coinManager.SaveToProgress();
        SceneManager.LoadScene(next-1);
    }
    }

  //  public void ShowReplayAllWindow () {
  //     _endWindow.SetActive(true);
  //  } 
  //  public void ReplayAllLevel () {
  //    int next = SceneManager.GetActiveScene().buildIndex + 1;
  //    if (next < SceneManager.sceneCountInBuildSettings){
  //      _coinManager.SaveToProgress();
  //        SceneManager.LoadScene(next-2);
  //    }
  //  }

}


