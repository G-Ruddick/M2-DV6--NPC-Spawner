using UnityEngine;

public class Criminal : MonoBehaviour, INPC {
    private string text = "You'll never catch me!";
    public string Speak() {
        // Debug.Log(text);
        return text;
    }
}