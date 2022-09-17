using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {    
        
        // GameObject.Find("Group1Button").onClick.AddListener(SwitchToGroup);
        // GameObject.Find("ProfileButton").onClick.AddListener(SwitchTo);
    }

    public void SwitchToGroup() {
        SceneManager.LoadScene(sceneName:"GroupScreen");
    }

    public void SwitchToHome() {
        SceneManager.LoadScene(sceneName:"HomeScreen");
    }

    public void SwitchToProfile() {
        SceneManager.LoadScene(sceneName:"ProfileScreen");
    }

}
