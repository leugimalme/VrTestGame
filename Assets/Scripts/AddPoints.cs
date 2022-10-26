using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class AddPoints : MonoBehaviour
{
    //UI Text GameObject
    public TextMeshProUGUI textmeshpro_Objective;
    int num = 0;
    // Start is called before the first frame update

    private void Awake()
    {
        TextChange();
    }

    public void TextChange()
    {
        textmeshpro_Objective.text = "" + num;
    }

    public void Puntos()
    {
        num = 1 + num;
        TextChange();
    }

    public void Puntos2(int Points)
    {
        num = Points + num;
        TextChange();
    }
}
