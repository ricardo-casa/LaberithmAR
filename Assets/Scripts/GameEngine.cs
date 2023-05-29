using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameEngine : MonoBehaviour
{
    public GameObject[] levels = new GameObject[3];
    public static int currentLevelIndex;
    public static int attempsDecreaser=3; 
    private float startTime = 300f; //equivalent to 5 minutes 
    private float currentTime = 0f; 
    public static int minutes;
    public static int seconds; 
    public Text CountDownText; 
    public Text AttempsText; 

    
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
        AttempsText.text = System.String.Format("Remaning Attemps: {0}", attempsDecreaser);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime > 0.1f)
        {
            currentTime -= 1 * Time.deltaTime;
            minutes = Mathf.FloorToInt(currentTime/60);
            seconds = (int)(currentTime % 60f);
            CountDownText.text = System.String.Format("Time Remaining  {0} : {1}", minutes, seconds);
        }
        else
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}