using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TrnsTextsLmao : MonoBehaviour
{
   public TransScript trans;
   public string Rus;
   public string Eng;
   public TMP_Text Ally;

   
    void Update()
    {
        if( trans.isGameTranslated == 1 )
        {
            Ally.text = Eng;
        }
        else
        {
            Ally.text = Rus;
        }

    }
}
