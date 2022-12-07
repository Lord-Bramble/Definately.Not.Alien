using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITextManager : MonoBehaviour
{
    public Text fuelCellText;
    public Text generatorText;
    public Text keycardText;
    public Text navCoordinatesText;
    public Text hypersleepText;
    public Text youWin;


    public void FuelCellGot()
    {
        fuelCellText.GetComponent<Text>().enabled = false;
    }
    public void GeneratorGot()
    {
        generatorText.GetComponent<Text>().enabled = false;
    }

    public void KeycardGot()
    {
       keycardText.GetComponent<Text>().enabled = false;
    }

    public void CoordinatesSetText()
    {
       navCoordinatesText.GetComponent<Text>().enabled = false;
    }

    public void GoneToSleep()
    {
        hypersleepText.GetComponent<Text>().enabled = false;
    }
    public void YouWinText()
    {
        youWin.GetComponent<Text>().enabled = true;
    }
}
