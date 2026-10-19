using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPCSpawner : MonoBehaviour {
    public NPCFactory m_Factory;
    public TMP_Text screenText;

    private INPC m_Farmer, m_Beggar, m_Shopowner, m_Criminal, m_Teacher, m_PoliceOfficer;

    public void SpawnVillagers() {
        SpawnNPC(m_Beggar, NPCType.Beggar);
        SpawnNPC(m_Farmer, NPCType.Farmer);
        SpawnNPC(m_Shopowner, NPCType.Shopowner);
        SpawnNPC(m_Criminal, NPCType.Criminal);
        SpawnNPC(m_Teacher, NPCType.Teacher);
        SpawnNPC(m_PoliceOfficer, NPCType.PoliceOfficer);
    }

    public void SpawnNPC(INPC person, NPCType type) {
        person = m_Factory.GetNPC(type);
        screenText.text += person.Speak() + "\n";
    }

    private void OnGUI() {
        if (GUI.Button(new Rect(0, 0, 100, 50), "Factory")) {
            SpawnVillagers();
        }

        if (GUI.Button(new Rect(0, 50, 100, 50), "Beggar")) {
            SpawnNPC(m_Beggar, NPCType.Beggar);
        }

        if (GUI.Button(new Rect(0, 100, 100, 50), "Farmer")) {
            SpawnNPC(m_Farmer, NPCType.Farmer);
        }

        if (GUI.Button(new Rect(0, 150, 100, 50), "ShopOwner")) {
            SpawnNPC(m_Shopowner, NPCType.Shopowner);
        }

        if (GUI.Button(new Rect(0, 200, 100, 50), "Criminal")) {
            SpawnNPC(m_Criminal, NPCType.Criminal);
        }

        if (GUI.Button(new Rect(0, 250, 100, 50), "Teacher")) {
            SpawnNPC(m_Teacher, NPCType.Teacher);
        }

        if (GUI.Button(new Rect(0, 300, 100, 50), "PoliceOfficer")) {
            SpawnNPC(m_PoliceOfficer, NPCType.PoliceOfficer);
        }
    }
}