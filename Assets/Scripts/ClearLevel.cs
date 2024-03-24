using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearLevel : MonoBehaviour
{

    public int changeSceneBuildIndex;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Initiate Entered");

        if(other.tag == "Player")
        {
            print("Switching Scene to" + changeSceneBuildIndex);
            SceneManager.LoadScene(changeSceneBuildIndex, LoadSceneMode.Single);
        }
    }
}
