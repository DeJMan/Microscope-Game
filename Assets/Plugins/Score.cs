using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
	{
		public int Health = 3;
		public int Points = 0;
		
		public Text HealthName;
		public Text PointsName;
		public Text HealthName2;
		public Text PointsName2;
		
		void Start()
		{
			HealthName.text = "Health: " + Health;
			HealthName2.text = "Health: " + Health;
			
			PointsName.text = "Score: " + Points;
			PointsName2.text = "Score: " + Points;
		}
		// Start is called before the first frame update
		public void Healthdecrease()
		{
			Health--;
			HealthName.text = "Health: " + Health;
			HealthName2.text = "Health: " + Health;
			if(Health <= 0)
			{
				//Gameover
				
				SetInt("lastscore", Points);
				SceneManager.LoadScene("gameover", LoadSceneMode.Single);
			}
		}
		
		// Update is called once per frame
		public void Scoreincrease()
		{
			Points++;
			PointsName.text = "Score: " + Points;
			PointsName2.text = "Score: " + Points;
		}
		
		public void SetInt(string KeyName, int Value)
		{
			PlayerPrefs.SetInt(KeyName, Value);
		}
		
		public int Getint(string KeyName)
		{
			return PlayerPrefs.GetInt(KeyName);
		}
		
		public void UpdateText()
		{
			HealthName.text = "Health: " + Health;
			HealthName2.text = "Health: " + Health;
			
			PointsName.text = "Score: " + Points;
			PointsName2.text = "Score: " + Points;
		}
	}
		