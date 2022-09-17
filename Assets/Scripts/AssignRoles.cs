using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AssignRoles : MonoBehaviour
{

    public int friend = -1;
    public int role = -1;

    public Button role1;
    public Button role2;
    public Button role3;
    public Button role4;
    public Button role5;

    public Button friend1;
    public Button friend2;
    public Button friend3;
    public Button friend4;
    public Button friend5;

    void Awake() {

        role1 = GameObject.Find("Choice1").GetComponent<Button>();
        role2 = GameObject.Find("Choice2").GetComponent<Button>();
        role3 = GameObject.Find("Choice3").GetComponent<Button>();
        role4 = GameObject.Find("Choice4").GetComponent<Button>();
        role5 = GameObject.Find("Choice5").GetComponent<Button>();

        friend1 = GameObject.Find("Choice1f").GetComponent<Button>();
        friend2 = GameObject.Find("Choice2f").GetComponent<Button>();
        friend3 = GameObject.Find("Choice3f").GetComponent<Button>();
        friend4 = GameObject.Find("Choice4f").GetComponent<Button>();
        friend5 = GameObject.Find("Choice5f").GetComponent<Button>();

    }


    // Start is called before the first frame update
    void Start()
    {
        
        role1.onClick.AddListener(delegate{SelectRole(1);});
        role2.onClick.AddListener(delegate{SelectRole(2);});
        role3.onClick.AddListener(delegate{SelectRole(3);});
        role4.onClick.AddListener(delegate{SelectRole(4);});
        role5.onClick.AddListener(delegate{SelectRole(5);});

        friend1.onClick.AddListener(delegate{SelectFriend(1);});
        friend2.onClick.AddListener(delegate{SelectFriend(2);});
        friend3.onClick.AddListener(delegate{SelectFriend(3);});
        friend4.onClick.AddListener(delegate{SelectFriend(4);});
        friend5.onClick.AddListener(delegate{SelectFriend(5);});

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectRole(int rolenum) {
        Debug.Log("Role Selected");

        if (friend == -1) {
            return;
        }
        else if (friend != -1 && role != -1) {
            GameObject.Find("RoleManager").GetComponent<LoadRoles>().SaveMatchData(friend, rolenum);
            friend = -1;
            role = -1;
            GameObject.Find("RoleManager").GetComponent<LoadRoles>().GetNewRoles();
        }

    }

    public void SelectFriend(int friendnum) {
        friend = friendnum;
        Debug.Log("Friend Selected");
    }


}
