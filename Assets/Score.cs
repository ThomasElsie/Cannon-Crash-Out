using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Text scoreDisplay;
    public int threeStars = 3;
    public int twoStars = 5;
    public int onestar = 7;
    public Animator scoreAnimator;
    public int nextLevel = 0;
    public void EndLevel()
    {
        Cannon cannon = FindObjectOfType<Cannon>();
        if (cannon)
        {
            int numProjectiles = cannon.numProjectiles;

            if (numProjectiles < threeStars)
            {
                print("3 STARS!");
                scoreDisplay.text = "3 STARS!";
                // Three Stars!
                scoreAnimator.SetInteger("Stars", 3);
            }
            else if (numProjectiles < twoStars)
            {
                print("2 Stars");
                scoreDisplay.text = "2 Stars";
                // Two Stars!
                scoreAnimator.SetInteger("Stars", 2);
            }
            else if (numProjectiles < onestar)
            {
                print("1 star...");
                scoreDisplay.text = "1 star...";
                // One Star!
                scoreAnimator.SetInteger("Stars", 1);
            }
            else
            {
                print("0 sta- how bad are you at this game?");
                scoreDisplay.text = "0 sta- how bad are you at this game?";
            }
            
            Invoke("NextLevel",2);
        }
    }

    void NextLevel()
    {
        SceneManager.LoadScene(nextLevel);
    }
}
