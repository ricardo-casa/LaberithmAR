using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class LoadNewSceneText : MonoBehaviour
{
    
    public TextMeshProUGUI CountDownText; 
    public TextMeshProUGUI AttempsText; 
    public TextMeshProUGUI Level; 
    // Start is called before the first frame update

    public void Start()
    {
        Level.text = System.String.Format("Level: {0}", GameEngine.currentLevelIndex+1);
        CountDownText.text = System.String.Format("Time Remaining:  {0} : {1}", GameEngine.minutes, GameEngine.seconds);
        AttempsText.text = System.String.Format("Attemps Remaining: {0}", GameEngine.attempsDecreaser);
    }
}
