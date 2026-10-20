using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPCSpawner : MonoBehaviour {
    public NPCFactory m_Factory;
    public TMP_Text screenText;

    public void SpawnVillagers() {
        screenText.text = "";

        SpawnNPC(NPCType.Beggar, false, -2.5f);
        SpawnNPC(NPCType.Farmer, true, -1.5f);
        SpawnNPC(NPCType.Shopowner, true, -0.5f);
        SpawnNPC(NPCType.Criminal, true, 0.5f);
        SpawnNPC(NPCType.Teacher, true, 1.5f);
        SpawnNPC(NPCType.PoliceOfficer, true, 2.5f);
    }

    public void SpawnNPC(NPCType type, bool multispawn = false, float spawnPosition = 0.0f) {
        INPC npc = m_Factory.GetNPC(type, multispawn, spawnPosition).npcScript as INPC;
        screenText.text += npc.Speak() + "\n";
    }

    private void OnGUI() {
        if (GUI.Button(new Rect(0, 0, 100, 50), "Factory")) {
            SpawnVillagers();
        }

        if (GUI.Button(new Rect(0, 50, 100, 50), "Beggar")) {
            SpawnNPC(NPCType.Beggar);
        }

        if (GUI.Button(new Rect(0, 100, 100, 50), "Farmer")) {
            SpawnNPC(NPCType.Farmer);
        }

        if (GUI.Button(new Rect(0, 150, 100, 50), "ShopOwner")) {
            SpawnNPC(NPCType.Shopowner);
        }

        if (GUI.Button(new Rect(0, 200, 100, 50), "Criminal")) {
            SpawnNPC(NPCType.Criminal);
        }

        if (GUI.Button(new Rect(0, 250, 100, 50), "Teacher")) {
            SpawnNPC(NPCType.Teacher);
        }

        if (GUI.Button(new Rect(0, 300, 100, 50), "PoliceOfficer")) {
            SpawnNPC(NPCType.PoliceOfficer);
        }
    }
}