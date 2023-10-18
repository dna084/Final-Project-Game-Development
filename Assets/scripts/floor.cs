using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Floor : MonoBehaviour
{
    public enum EncounterType { Enemy, Elite, Chest, Rest };
    public EncounterType encounterType;
    public EncounterType[] floorEncounterTypes;

    public List<encounterNode> nodes;

    public void SetNodesActiveClickable(Floor.EncounterType encounterType)
    {
        int floorIndex = 0;
        if (floorIndex < floorEncounterTypes.Length)
        {
            if (encounterType == floorEncounterTypes[floorIndex])
            {
                foreach (var node in nodes)
                {
                    node.gameObject.GetComponent<Button>().interactable = true;
                }
            //after testing, this should load encounter specific scene
            //node.gameObject.GetComponent<Button>().onClick.AddListener(() => LoadScene(node.encounterType + "Scene"));
            }
            else
            {
                foreach (var node in nodes)
                {
                    // Make the button uninteractable
                    node.gameObject.GetComponent<Button>().interactable = false;
                }
            }
        }
    }

    public void SetNodesActive(Floor.EncounterType encounterType)
    {
        foreach (var node in nodes)
        {
        if (node.encounterType == encounterType.ToString())
        {
            // Your button creation and scene loading logic here
        }
        }
    }       

}