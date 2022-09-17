using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadRoles : MonoBehaviour
{

    public int questions_left = 3;

    List<int> role1 = new List<int>();
    List<int> role2 = new List<int>();
    List<int> role3 = new List<int>();
    List<int> role4 = new List<int>();
    List<int> role5 = new List<int>();

    List<int> friend1 = new List<int>();
    List<int> friend2 = new List<int>();
    List<int> friend3 = new List<int>();
    List<int> friend4 = new List<int>();
    List<int> friend5 = new List<int>();

    public List<List<int>> friends = new List<List<int>>();

    List<GameObject> friendImages = new List<GameObject>();
    List<GameObject> questionImages = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        friends.Add(friend1);
        friends.Add(friend2);
        friends.Add(friend3);
        friends.Add(friend4);
        friends.Add(friend5);



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveMatchData(int friendnum, int rolenum) {
        
    }

    public void GetNewRoles() {

        GameObject choiceImg = GameObject.Find("ChoiceSelectionBackgroundImage" + questions_left.ToString());
        choiceImg.active = false;
        questions_left = questions_left - 1;

        if (questions_left == 0) {
            ShowEndScreen();
            return;
        }
        choiceImg = GameObject.Find("ChoiceSelectionBackgroundImage" + questions_left.ToString());
        choiceImg.active = true;



    }

    public void ShowEndScreen() {
        GameObject endImg = GameObject.Find("EndImage");
        endImg.active = true;
    }

}
