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
        Debug.Log("Group\n");
        SceneManager.LoadScene(sceneName:"GroupScene2");
    }

    public void SwitchToHome() {
        Debug.Log("Home\n");
        SceneManager.LoadScene(sceneName:"HomeScreen");
    }

    public void SwitchToProfile() {
        Debug.Log("Profile\n");
        SceneManager.LoadScene(sceneName:"ProfileScreen");
    }

}
