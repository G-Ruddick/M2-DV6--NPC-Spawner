using UnityEngine;

public class Beggar : MonoBehaviour, INPC {
    private string text = "Do you have some change to spare?";
    public string Speak() {
        // Debug.Log(text);
        return text;
    }
}