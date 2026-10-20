using UnityEngine;

public class PoliceOfficer : MonoBehaviour, INPC {
    private string text = "You're under arrest!";
    public string Speak() {
        // Debug.Log(text);
        return text;
    }
}