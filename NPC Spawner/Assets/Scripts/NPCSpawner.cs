using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPCSpawner : MonoBehaviour {
    public NPCFactory m_Factory;
    public TMP_Text screenText;

    private INPC m_Farmer;
    private INPC m_Beggar;
    private INPC m_Shopowner;

    public void SpawnVillagers() {
        SpawnBeggar();
        SpawnFarmer();
        SpawnShopowner();
    }

    public void SpawnBeggar() {
        m_Beggar = m_Factory.GetNPC(NPCType.Beggar);
        screenText.text += m_Beggar.Speak() + "\n";
    }

    public void SpawnFarmer() {
        m_Farmer = m_Factory.GetNPC(NPCType.Farmer);
        screenText.text += m_Farmer.Speak() + "\n";
    }

    public void SpawnShopowner() {
        m_Shopowner = m_Factory.GetNPC(NPCType.Shopowner);
        screenText.text += m_Shopowner.Speak() + "\n";
    }

    private void OnGUI() {
        if (GUI.Button(new Rect(0, 0, 100, 50), "Factory")) {
            SpawnVillagers();
        }
        if (GUI.Button(new Rect(0, 50, 100, 50), "Beggar")) {
            SpawnBeggar();
        }
        if (GUI.Button(new Rect(0, 100, 100, 50), "Farmer")) {
            SpawnFarmer();
        }
        if (GUI.Button(new Rect(0, 150, 100, 50), "ShopOwner")) {
            SpawnShopowner();
        }
    }
}