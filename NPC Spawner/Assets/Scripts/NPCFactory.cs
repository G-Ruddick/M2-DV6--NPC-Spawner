using UnityEngine;

public enum NPCType { Farmer, Beggar, Shopowner, Teacher, Criminal, PoliceOfficer }

public class NPCFactory : MonoBehaviour {
    public INPC GetNPC(NPCType type) {
        switch (type) {
            case NPCType.Beggar:
                INPC beggar = new Beggar();
                return beggar;
            case NPCType.Farmer:
                INPC farmer = new Farmer();
                return farmer;
            case NPCType.Shopowner:
                INPC shopowner = new Shopowner();
                return shopowner;
            case NPCType.Teacher:
                INPC teacher = new Teacher();
                return teacher;
            case NPCType.Criminal:
                INPC criminal = new Criminal();
                return criminal;
            case NPCType.PoliceOfficer:
                INPC policeOfficer = new PoliceOfficer();
                return policeOfficer;
        }

        return null;
    }
}