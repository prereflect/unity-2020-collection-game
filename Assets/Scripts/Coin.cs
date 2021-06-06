using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //Keeps track of total coin count in scene
    public static int CoinCount = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        //Object created, increment coin count
        ++Coin.CoinCount;
    }

	void OnTriggerEnter(Collider Col)
	{
		//If player collected coin, then destroy object
		if (Col.CompareTag("Player"))
		{
			Destroy(gameObject);
		}
	}

    //Called when object is destroyed
    void OnDestroy()
    {
        --Coin.CoinCount;

        if(Coin.CoinCount <= 0)
        {
            //We have won
        }
    }
}
