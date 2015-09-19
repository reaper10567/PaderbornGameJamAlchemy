using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Game : MonoBehaviour {

    public Canvas inventoryCanvas;

    public Button inventoryToggle;

    public List<string> inventory;

    // Use this for initialization
	void Start () {
        inventoryToggle = inventoryToggle.GetComponent<Button>();

        inventoryToggle.onClick.AddListener(ToggleInventory);

        inventory = new List<string>();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    // show/hide the inventory
    void ToggleInventory()
    {
        inventoryCanvas.gameObject.SetActive(!inventoryCanvas.gameObject.activeSelf);
        Debug.Log("Inventory toggled...");
    }

    void addLetter(string letter)
    {
        inventory.Add(letter);
    }
}
