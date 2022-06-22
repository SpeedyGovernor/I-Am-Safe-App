//IN PROGRESS

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class ButtonPress : MonoBehaviour
{

    public string theNum;
    public GameObject inputField; //for number

 //   public InputField phoneNuminput;

    public void SavePlayer ()
    {
        SaveNumber.SaveNum();
        Debug.Log("Save function executed!");
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveNumber.LoadPlayer();
        theNum = data.phoneNumber;
        Debug.Log("Load function working, number = " + theNum);
    }

    public void TestFunction()
    {
        Debug.Log("You have clicked the alert button!");
        Debug.Log(theNum + " is your number!");
    }

    public void NumTest()
    {
        theNum = inputField.GetComponent<Text>().text;
        Debug.Log(theNum);
    }

}
