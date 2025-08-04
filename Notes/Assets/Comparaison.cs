using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Comparaison : MonoBehaviour
{

    public static List<double> noteGSemester = new List<double>(){0 ,0, 0};
    // Start is called before the first frame update
    void Start()
    {
    }

    public static void SaveG()
    {
        if (!File.Exists(Application.dataPath + $"/saveAllG.txt"))
        {
            var okk = File.Create(Application.dataPath + $"/saveAllG.txt");
            okk.Close();
        }
        else
        {
            string newStr = "";
            for (int i = 0; i < 3; i++)
            {
                newStr += noteGSemester[i];
                newStr += "|";
                //Debug.Log(noteGSemester[i]);
            }
            File.WriteAllText(Application.dataPath + "/" + $"/saveAllG.txt", newStr);
        }
    }

    public void returnBack()
    {
        SceneManager.LoadScene("Menu");
    }

    public void goIn()
    {
        SceneManager.LoadScene("Comp");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
