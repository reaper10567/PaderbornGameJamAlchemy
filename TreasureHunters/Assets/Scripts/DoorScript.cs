using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        openDoor();
    }

    private void openDoor()
    {
        bool rightkey = true;
        print("put door open function here");
        //quickest and dirtiest
        if (rightkey)
        {
            transform.parent.Translate(1000, 0, 0);
        }
    }
}
