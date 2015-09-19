using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour
{
		// instance variables, aka fields 
		public float speed = 2;
		public float spin = 4;
		

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
			
				// rotate with left/right  
				if (Input.GetKey (KeyCode.RightArrow)) {
						transform.Rotate (0, 0, -spin);	
						
						
				}
				if (Input.GetKey (KeyCode.LeftArrow)) {
						transform.Rotate (0, 0, spin);	
						
				}

				//move with up/down
				if (Input.GetKey (KeyCode.UpArrow)) {
						transform.Translate (speed * Time.deltaTime, 0f, 0f);
						
				}
				if (Input.GetKey (KeyCode.DownArrow)) {	
						transform.Translate (-speed * Time.deltaTime, 0f, 0f);
					
				}
				
		}
}
