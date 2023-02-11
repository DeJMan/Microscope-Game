using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverscreendisplay : MonoBehaviour
{
	
	public int Points = 0;
	public int Highscore = 0;
	
	public Text highscore;
	public Text points;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("lastscore"))
		{
			Points = PlayerPrefs.GetInt("lastscore");
		}
		
		 if(PlayerPrefs.HasKey("highscore"))
		{
			Highscore = PlayerPrefs.GetInt("highscore");
			}
			else
			{
		Highscore = Points;
				PlayerPrefs.SetInt("highscore", Points);
				}
				
				if(Points > Highscore)
			{
				Highscore = Points;
				PlayerPrefs.SetInt("highscore", Points);	
					}
			points.text = "Points: " + Points;
			highscore.text = "Highscore: " + Highscore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
