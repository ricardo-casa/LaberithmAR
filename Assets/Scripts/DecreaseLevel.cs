using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DecreaseLevel : MonoBehaviour
{
    public GameEngine ge; 

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Sphere")
       {
            if (GameEngine.attempsDecreaser > 0)
            { 
                if (GameEngine.currentLevelIndex == 0)
                {  
                    Destroy(collider.gameObject);
                    GameEngine.attempsDecreaser --;
                }   

                else //decrease level
                {   
                    Destroy(collider.gameObject);
                    ge.levels[GameEngine.currentLevelIndex].SetActive(false);
                    GameEngine.currentLevelIndex --;
                    ge.levels[GameEngine.currentLevelIndex].SetActive(true); // TEMPORARY ON FIRST LEVEL
                    GameEngine.attempsDecreaser --;
                }
                ge.AttempsText.text = System.String.Format("Remaning Attemps: {0}", GameEngine.attempsDecreaser);
            }

            else // if theres no remaining attemps 
            {
                //change to game over scene
                ge.AttempsText.text = System.String.Format("Remaning Attemps: {0}", GameEngine.attempsDecreaser);
                SceneManager.LoadScene("GameOver");
            }
        }
    }
}
