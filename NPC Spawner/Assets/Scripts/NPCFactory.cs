using UnityEngine;
using System.Collections.Generic;

public enum NPCType { Farmer, Beggar, Shopowner, Teacher, Criminal, PoliceOfficer }

public class NPCFactory : MonoBehaviour {
    public GameObject farmer, beggar, shopowner, teacher, criminal, policeOfficer;
    private List<GameObject> NPC = new List<GameObject>();
    
    public NPCPrefab GetNPC(NPCType type, bool multispawn, float spawnPosition) {
        if (!multispawn) {
            while (NPC.Count > 0) {
                Destroy(NPC[0]);

                NPC.RemoveAt(0);
            }
        }

        switch (type) {
            case NPCType.Beggar:
                return CreateNPC(beggar, spawnPosition);

            case NPCType.Farmer:
                return CreateNPC(farmer, spawnPosition);

            case NPCType.Shopowner:
                return CreateNPC(shopowner, spawnPosition);

            case NPCType.Teacher:
                return CreateNPC(teacher, spawnPosition);

            case NPCType.Criminal:
                return CreateNPC(criminal, spawnPosition);

            case NPCType.PoliceOfficer:
                return CreateNPC(policeOfficer, spawnPosition);
        }

        return null;
    }

    private NPCPrefab CreateNPC(GameObject person, float spawnPosition) {
        GameObject npc = Instantiate(person, new Vector3(spawnPosition, 0.5f, 0), Quaternion.identity);
        NPCPrefab villager = npc.GetComponent<NPCPrefab>();
        NPC.Add(npc);
        return villager;
    }
}