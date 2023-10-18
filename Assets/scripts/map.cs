using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Map : MonoBehaviour
{
    public enum EncounterType { Default, Enemy, Elite, Chest, Rest};


    public List<Floor> floors;
    public GameObject encounterPrefab; // This will be a prefab used for encounters
    public Image enemyIcon, eliteIcon;
    public int eliteFloors;
    public int chestFloors;
    public int restFloors;
    public EncounterInfo enemyEncounter;
    public EncounterInfo eliteEncounter;
    public EncounterInfo chestEncounter;
    public EncounterInfo restEncounter;
    public int currentFloorNumber;

    private void Awake()
    {
        for (int i = 0; i < floors.Count; i++)
        {
            floors[i].SetNodesActive((Floor.EncounterType)i);
        }
}

    public void ShowOptions()
    {
        Debug.Log("Showing options");
        if (currentFloorNumber == floors.Count)
        {
            currentFloorNumber = 0;
            GenerateMap();
            return;
        }

        for (int i = 0; i < floors.Count; i++)
        {
            if (i == currentFloorNumber)
                floors[i].SetNodesActiveClickable((Floor.EncounterType)i);
        }
        currentFloorNumber++;
    }

    public void GenerateMap()
    {
        for (int i = 0; i < floors.Count; i++)
        {
            floors[i].SetNodesActive((Floor.EncounterType)i);
        }
        ShowOptions();
    }

        public void SetNodesActive(Floor.EncounterType encounterType)
        {
            foreach (var floor in floors){

                foreach (var node in floor.nodes)
                {
                    if (node.encounterType == encounterType.ToString())
                    {
                        Debug.Log(""+ encounterType.ToString());
                        floor.SetNodesActiveClickable(encounterType);
                    }
                }
            }
        }

    public void ConnectFloors(Floor parentNodes, Floor childNodes)
    {
        // Your code for connecting floors
    }
}

[System.Serializable]
public struct EncounterInfo
{
    public Type encounterType;
    public enum Type { enemy, elite, chest, rest };
    public Sprite encounterSprite;
}
