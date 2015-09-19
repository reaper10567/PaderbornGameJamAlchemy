using UnityEngine;
using System.Collections;

public class ChestScript : MonoBehaviour {

    public string loot = "A";
    public string GameControlClass = "GameControl";
    bool looted = false;
    public Sprite openedChest;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (!looted)
        {
            GameObject.Find(GameControlClass).GetComponent<Game>().addLetter(loot);
            GameObject.Find("pickupTile").GetComponent<ShowPickup>().showPickup(loot);
            print("looted " + loot);
            looted = true;
            GetComponent<SpriteRenderer>().sprite = openedChest;
        }
    }

}
