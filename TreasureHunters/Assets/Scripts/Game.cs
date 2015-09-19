using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Game : MonoBehaviour {
    public GameObject inventoryItems;

    public Canvas inventoryCanvas;

    public Button inventoryToggle;

    public List<string> inventory;

    public Button letterA;
    public Button letterE;
    public Button letterI;

    private Dictionary<string,Texture> letters;

    // Use this for initialization
	void Start () {

        inventoryToggle = inventoryToggle.GetComponent<Button>();

        inventoryToggle.onClick.AddListener(ToggleInventory);

        inventory = new List<string>();
	}
	
	// Update is called once per frame
	void Update () {
        Transform[] transformArray = inventoryItems.GetComponentsInChildren<Transform>();
        if (transformArray == null && transformArray.Length != inventory.Count)
        {
            foreach (Transform item in transformArray)
            {
                //Destroy(item);
            }
            Texture texture;
            foreach (string letter in inventory)
            {
                if (letters.TryGetValue(letter, out texture))
                {
                    if (letter.Equals("a")) {
                        letterA.enabled = true;
                    }
                    if (letter.Equals("e"))
                    {
                        letterE.enabled = true;
                    }
                    if (letter.Equals("i"))
                    {
                        letterI.enabled = true;
                    }
                }
            }
        }
	}

    // show/hide the inventory
    void ToggleInventory()
    {
        inventoryCanvas.gameObject.SetActive(!inventoryCanvas.gameObject.activeSelf);
        Debug.Log("Inventory toggled...");
    }

    public void addLetter(string letter)
    {
        inventory.Add(letter);
    }
}
