using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
	public GameObject canon1, canon2, canon3, canon4, canon5;
    void Start()
    {
	    GameGlobals.Coins = 100;
    }

    // Update is called once per frame
    void Update()
	{
		Debug.Log(GameGlobals.Coins);
    	
	    if (GameGlobals.Coins >= 50){
	    	canon1.SetActive(true);
	    }
	    else {
	    	canon1.SetActive(false);
	    }
	    
	    
	    if (GameGlobals.Coins >= 100){
	    	canon2.SetActive(true);
	    }
	    else {
	    	canon2.SetActive(false);
	    }
	    
	    if (GameGlobals.Coins >= 150){
	    	canon3.SetActive(true);
	    }
	    else {
	    	canon3.SetActive(false);
	    }
	    
	    if (GameGlobals.Coins >= 200){
	    	canon4.SetActive(true);
	    }
	    else {
	    	canon4.SetActive(false);
	    }
	    
	    if (GameGlobals.Coins >= 300){
	    	canon5.SetActive(true);
	    }
	    else {
	    	canon5.SetActive(false);
	    }
    }
    
	public void Cañon1(){
		GameGlobals.Coins -= 50;
	}
	
	public void Cañon2(){
		GameGlobals.Coins -= 100;
	}
    
	public void Cañon3(){
		GameGlobals.Coins -= 150;
	}
	
	public void Cañon4(){
		GameGlobals.Coins -= 200;
	}
	
	public void Cañon5(){
		GameGlobals.Coins -= 300;
	}
}
