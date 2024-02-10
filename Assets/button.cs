using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject player;
    public int stateOFplayer2;
    public GameObject[] destoryObj;

    // Start is called before the first frame update
    void Start()
    {
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

        if((player.transform.localPosition.x>=(-4.2))&&(player.transform.localPosition.x<=(-3.2)))
        {
            if(Input.GetKeyDown(KeyCode.N))
            {
                if(stateOFplayer2==2)
                {

                    Destroy(destoryObj[1]);
                    
                }           
            }

        }
        
        
    }
}
