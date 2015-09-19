using UnityEngine;
using System.Collections;

public class ShowPickup : MonoBehaviour {

    public float showTime = 2;
    public Sprite a;
    public Sprite e;
    public Sprite i;
    public Sprite u;
    public Sprite defaultTile;
    float timeLeft = 0;
    SpriteRenderer renderer;

    // Use this for initialization
    void Start () {
       renderer = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
	    if (timeLeft < 0)
        {
            renderer.enabled = false;
        }
        timeLeft -= Time.deltaTime;
	}

    public void showPickup(string Item)
    {
        switch (Item)
        {
            case "a":
                renderer.sprite = a;
                break;
            case "e":
                renderer.sprite = e;
                break;
            case "i":
                renderer.sprite = i;
                break;
            case "u":
                renderer.sprite = u;
                break;
            default:
                renderer.sprite = defaultTile;
                break;
        }
        renderer.enabled = true;
        timeLeft = showTime;
    }
}
