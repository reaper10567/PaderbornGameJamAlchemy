using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour
{

    public float stepSize = 1;
    public CollisionReport northColl;
    public CollisionReport westColl;
    public CollisionReport eastColl;
    public CollisionReport southColl;
    WalkAnimation walkAnim;
    // Use this for initialization
    void Start ()
	{
        walkAnim = GameObject.Find("Character").GetComponent<WalkAnimation>();
	}
	
	// Update is called once per frame
	void Update ()
	{
    //
    if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.W))
        {
            if (!northColl.colliding)
            {
                transform.Translate(0, stepSize, 0f);
                walkAnim.moveNorth();
            }
	    }
    if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S))
        {
            if (!southColl.colliding)
            {
                transform.Translate(0, -stepSize, 0f);
                walkAnim.moveSouth();
            }
	    }
    if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D))
        {
            if (!eastColl.colliding)
            {
                transform.Translate(stepSize, 0, 0f);
                walkAnim.moveEast();
            }
	    }
    if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A))
        {
            if (!westColl.colliding)
            {
                transform.Translate(-stepSize, 0, 0f);
                walkAnim.moveWest();
            }
        }
	}
}
