using UnityEngine;

public class Teacher : INPC {
    private string text = "Time for school.";
    public string Speak() {
        Debug.Log(text);
        return text;
    }
}