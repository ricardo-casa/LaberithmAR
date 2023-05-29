using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IncreaseLevel : MonoBehaviour
{
    //public GameObject[] levels = new GameObject[3];
    //public int currentLevelIndex;

    public GameEngine ge; 
    

    // Start is called before the first frame update
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Sphere")
        {
            ge.levels[GameEngine.currentLevelIndex].SetActive(false);
            Destroy(collider.gameObject);

            if (GameEngine.currentLevelIndex < 2)
            {  
                GameEngine.currentLevelIndex++;
                ge.levels[GameEngine.currentLevelIndex].SetActive(true);
            }   

            else // Change scene to final game scene
            {   
                SceneManager.LoadScene("Win");
               
            }
        }
    }

}
