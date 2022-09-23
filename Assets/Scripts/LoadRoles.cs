using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadRoles : MonoBehaviour
{

    public GameObject choiceImg1;
    public GameObject choiceImg2;
    public GameObject choiceImg3;
    public GameObject endImg;

    public int questions_left = 1;

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

    List<GameObject> questionImages = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        friends.Add(friend1);
        friends.Add(friend2);
        friends.Add(friend3);
        friends.Add(friend4);
        friends.Add(friend5);
        questionImages.Add(choiceImg1);
        questionImages.Add(choiceImg2);
        questionImages.Add(choiceImg3);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveMatchData(int friendnum, int rolenum) {
        
    }

    public void GetNewRoles() {


        GameObject choiceImg = questionImages[questions_left - 1];
        choiceImg.active = false;
        questions_left = questions_left - 1;

        if (questions_left == 0) {
            ShowEndScreen();
            return;
        }
        choiceImg = questionImages[questions_left - 1];
        choiceImg.active = true;



    }

    public void ShowEndScreen() {
        
        endImg.active = true;
    }

}