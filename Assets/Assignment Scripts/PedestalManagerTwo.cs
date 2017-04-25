using UnityEngine;
using System.Collections;

public class PedestalManagerTwo : MonoBehaviour
{
    public GameObject objective, question;
    public GameObject[] pedestal;
    public ContentDDM cont;
    private int temp;//, v1, v2, v3;
    private string pedestalQ;
    public string pedestalA;
    private char[] pedestalNums;
    private string[] ansarr = new string[] { "", "", "", "" };
    private string[] options = new string[] { "there", "their", "they're", "they've", "they'd", "they'll", "dare", //0-6
        "lock", "how", "Hiccough", "thought", "brought", "shot", "now", "dock", "flock", "hot", "fought", "caught", // 7-18
        "hurry", "elegant", "gallop", "lope", " former", "old-fashioned", "outmoded", "passe", "veteran", "mature", "voice","articulate", "pronounce","precise", "exact", "valid", "genuine" }; //19-35

    // Use this for initialization
    public void Start()
    {

        FrameworkCore.setContent(new ContentDDM());
        objective.GetComponent<TextMesh>().text = FrameworkCore.currentContent.getTerm();

        ContentDDM cont = (ContentDDM)FrameworkCore.currentContent;

        temp = Random.Range(0, 13);
        pedestalQ = cont.getQuestion(temp);
        question.GetComponent<TextMesh>().text = pedestalQ;
        pedestalA = cont.getAnswer(temp);
        assign();
        /*
        ansarr[0] = pedestalA;
        ansarr[1] = options[Random.Range(0, 5)];
        ansarr[2] = options[Random.Range(0, 5)];
        ansarr[3] = options[Random.Range(0, 5)];
        */
        for (int x = 0; x < 15; x++)
        {
            Randomize();
        }

        generatePedestal();
    }

    private void assign()
    {
        int t1=0, t2=0;
        if (temp < 3){
            t1 = 0;
            t2 = 6;
        }
        if (temp >=3 && temp <=6)
        {
            t1 = 7;
            t2 = 18;
        }
        if (temp >= 7)
        {
            t1 = 19;
            t2 = 35;
        }
        ansarr[0] = pedestalA;
        ansarr[1] = options[Random.Range(t1, t2)];
        ansarr[2] = options[Random.Range(t1, t2)];
        ansarr[3] = options[Random.Range(t1, t2)];
    }

    private void generatePedestal()
    {
        for (int x = 0; x < 4; x++)
        {
            pedestal[x].GetComponent<TextMesh>().text = ansarr[x].ToString();
        }
    }

    private void Randomize()
    {
        int a = Random.Range(0, 3);
        int b = Random.Range(0, 3);
        string t;
        t = ansarr[a];
        ansarr[a] = ansarr[b];
        ansarr[b] = t;
    }

}
