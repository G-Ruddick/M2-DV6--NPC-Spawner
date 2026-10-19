using UnityEngine;

public class PoliceOfficer : INPC {
    private string text = "You're under arrest!";
    public string Speak() {
        Debug.Log(text);
        return text;
    }
}