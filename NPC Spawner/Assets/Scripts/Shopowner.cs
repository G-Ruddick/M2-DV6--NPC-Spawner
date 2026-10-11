using UnityEngine;

public class Shopowner : INPC {
    private string text = "Do you wish to purchase something?";
    public string Speak() {
        Debug.Log(text);
        return text;
    }
}