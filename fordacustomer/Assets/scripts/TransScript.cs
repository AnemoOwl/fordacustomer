using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransScript : MonoBehaviour
{
   public int isGameTranslated = 1;

    private void Start()
    {
        if(PlayerPrefs.HasKey("Translation"))
        {
            isGameTranslated = PlayerPrefs.GetInt("Translation");
        }
    }

    public void ChangeTranslation()
    {
        if(isGameTranslated == 0)
        {
            isGameTranslated = 1;
            PlayerPrefs.SetInt("Translation", isGameTranslated);
        }
        else
        {
            isGameTranslated = 0;
            PlayerPrefs.SetInt("Translation", isGameTranslated);
        }
        PlayerPrefs.Save();
    }
}
