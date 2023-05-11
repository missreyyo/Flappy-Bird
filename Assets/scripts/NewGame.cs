using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewGame : MonoBehaviour
{
    public Button newGameButton;

    private void Start()
    {
        newGameButton.onClick.AddListener(NewGameButton);
    }
   void NewGameButton(){
       SceneManager.LoadScene("SampleScene");
   }
}
