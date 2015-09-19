using UnityEngine;
using System.Collections.Generic;

public class WalkAnimation : MonoBehaviour {

    public List<Sprite> North;
    public List<Sprite> West;
    public List<Sprite> East;
    public List<Sprite> South;
    List<Sprite>.Enumerator ne;
    List<Sprite>.Enumerator we;
    List<Sprite>.Enumerator ee;
    List<Sprite>.Enumerator se;

    void Start()
    {
        ne = North.GetEnumerator();
        we = West.GetEnumerator();
        ee = East.GetEnumerator();
        se = South.GetEnumerator();
    }

    public void moveNorth()
    {
        if (!ne.MoveNext())
        {
            ne = North.GetEnumerator();
            ne.MoveNext();
        }
        GetComponent<SpriteRenderer>().sprite = ne.Current;
    }

    public void moveWest()
    {
        if (!we.MoveNext())
        {
            we = West.GetEnumerator();
            we.MoveNext();
        }
        GetComponent<SpriteRenderer>().sprite = we.Current;
    }

    public void moveEast()
    {
        if (!ee.MoveNext())
        {
            ee = East.GetEnumerator();
            ee.MoveNext();
        }
        GetComponent<SpriteRenderer>().sprite = ee.Current;
    }

    public void moveSouth()
    {
        if (!se.MoveNext())
        {
            se = South.GetEnumerator();
            se.MoveNext();
        }
        GetComponent<SpriteRenderer>().sprite = se.Current;
    }
}
