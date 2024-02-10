using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigbutton : MonoBehaviour
{
    public GameObject player1;
    public int stateOFplayer1;

    public GameObject player2;
    public int stateOFplayer2;

    public GameObject finalWall;

    // Start is called before the first frame update
    void Start()
    {
        stateOFplayer1 = 1;
        stateOFplayer2 = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            if(stateOFplayer2==1)
            {
                stateOFplayer2=2;
            }

            else
            {
                stateOFplayer2=1;
            }

        }

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
       
        if((player1.transform.localPosition.y<=(-3))&&(player2.transform.localPosition.y<=(-3)))
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                if((stateOFplayer2==2)&&(stateOFplayer1==2))
                {
                    if((player1.transform.position.x>=2))
                    {
                        if(player2.transform.position.x<=(3.6))
                        Destroy(finalWall);   
                    }   

                    else if(player2.transform.position.x>2)
                    {
                        if((player1.transform.position.x<(3.6)))
                        Destroy(finalWall);   
                    }                
                }           
            }
        }


        

       
    }
}
