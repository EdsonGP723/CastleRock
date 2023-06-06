using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CastleManager : MonoBehaviour
{
	private float life = 15; 
	public GameObject gameOverCanva, cañonesCanva;
   
	void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Enemy")){
			life-= 2;
			other.gameObject.SetActive(false);
		}
	}
	
	// Update is called every frame, if the MonoBehaviour is enabled.
	protected void Update()
	{
		Debug.Log("Vida castillo" + life);
		if (life <= 0){
			cañonesCanva.SetActive(false);
			gameOverCanva.SetActive(true);
		}
	}
	
	public void ReloadScene(){
		SceneManager.LoadScene(0);
	}
	
	public void Exit(){
		Application.Quit();
	}
}
