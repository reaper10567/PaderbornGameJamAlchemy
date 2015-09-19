using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour
{

    public float stepSize = 1;
		

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
			
				//
            if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                    transform.Translate(0,stepSize, 0f);
						
						
				}
                if (Input.GetKeyUp(KeyCode.DownArrow))
                {
						transform.Translate (0,-stepSize, 0f);
						
				}

                if (Input.GetKeyUp(KeyCode.RightArrow))
                {
						transform.Translate (stepSize,0, 0f);
						
				}
                if (Input.GetKeyUp(KeyCode.LeftArrow))
                {
                    transform.Translate(-stepSize,0, 0f);
					
				}
				
		}
}
