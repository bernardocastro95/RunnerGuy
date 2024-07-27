using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public UiManager ui;
    public Character character;  

    // Update is called once per frame
    void Update()
    {
        if(character.hit == true)
        { 
            ui.highScoreSetter();
            ui.timeScoreSetter();
            ui.gameOverText();
            intervalGameStop();
            ui.revealBUtton();
        }
    }
    
    IEnumerator intervalGameStop()
    {
        yield return new WaitForSeconds(3);
        Time.timeScale = 0;
    }
}
