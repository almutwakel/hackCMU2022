using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {    
    }

    void SwitchToGroup() {
        SceneManager.LoadScene(sceneName:"GroupScreen");
    }

    void SwitchToHome() {
        SceneManager.LoadScene(sceneName:"HomeScreen");
    }

    void SwitchToProfile() {
        SceneManager.LoadScene(sceneName:"ProfileScreen");
    }

}
