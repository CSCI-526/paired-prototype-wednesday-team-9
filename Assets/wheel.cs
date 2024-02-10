using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheel : MonoBehaviour
{
    public GameObject player;
    public int stateOFplayer1;
    public GameObject elevator;
    public bool elevatorMoving;
    // Start is called before the first frame update
    void Start()
    {
        stateOFplayer1 = 1;
        elevatorMoving = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            if(stateOFplayer1==1)
            {
                stateOFplayer1=2;
            }

            else
            {
                stateOFplayer1=1;
            }

        }
        // Debug.Log(player.transform.localPosition.x);
        if((player.transform.localPosition.x>=(-2.1))&&(Input.GetKeyDown(KeyCode.E))){
            if(stateOFplayer1==1)
            {
                elevatorMoving = true;
                // Debug.Log(elevator.transform.localPosition.x);
                // elevator.transform.position += new Vector3(0, 2, 0);                
            }
        }

        if(elevatorMoving&&(elevator.transform.localPosition.y>-0.58))
        {
            elevator.transform.position += new Vector3(0, -0.01f, 0);
        }
        
    }
}
