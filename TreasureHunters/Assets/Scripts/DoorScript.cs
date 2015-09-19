using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour {

	public string word;
	AudioSource theWord;
    public bool rightkey = true;
    // Use this for initialization
    void Start () {
		theWord = GameObject.Find (word).GetComponent<AudioSource> ();
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
        
        print("put door open function here");
		theWord.Play();
        //quickest and dirtiest
        if (rightkey)
        {
            transform.parent.Translate(1000, 0, 0);
        }
    }
}
