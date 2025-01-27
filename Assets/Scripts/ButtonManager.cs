using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class ButtonManager : MonoBehaviour {
    // <<< MENU SCENE >>>
    public void PlayBoatGame() {
        SceneManager.LoadScene("SplitRaceBoats");
    }


    // <<< BOAT GAME SCENE >>>
    public void RestartBoatGame() {
        // TODO
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        //InGameCanvasBehaviour.SetUp();
    }
    
    public void GoToMenu() {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame() {
        Application.Quit();
    }
}
