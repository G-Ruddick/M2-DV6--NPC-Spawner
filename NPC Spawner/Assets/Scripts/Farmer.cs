using UnityEngine;

public class Farmer : MonoBehaviour, INPC {
    private string text = "You reap what you sow!";
    public string Speak() {
        // Debug.Log(text);
        return text;
    }
}