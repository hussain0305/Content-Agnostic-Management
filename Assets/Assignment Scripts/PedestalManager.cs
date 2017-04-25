using UnityEngine;
using System.Collections;

public class PedestalManager : MonoBehaviour
{
    public GameObject objective, question;
    public GameObject[] pedestal;
    public ContentSDM cont;
    private int temp;//, v1, v2, v3;
    private string pedestalQ;
    public int pedestalA;
    private char[] pedestalNums;
    private int[] ansarr = new int[] { 0, 0, 0, 0 };
    
    // Use this for initialization
    public void Start()
    {

        FrameworkCore.setContent(new ContentSDM());
        objective.GetComponent<TextMesh>().text = FrameworkCore.currentContent.getTerm();
        
        ContentSDM cont = (ContentSDM)FrameworkCore.currentContent;

        temp = Random.Range(0, 15);
        pedestalQ = cont.getQuestion(temp);
        question.GetComponent<TextMesh>().text = pedestalQ;
        pedestalA = cont.getAnswer(temp);
        ansarr[0] = pedestalA;
        ansarr[1] = Random.Range(0, 20);
        ansarr[2] = Random.Range(0, 20);
        ansarr[3] = Random.Range(0, 20);
        for(int x = 0; x < 15; x++)
        {
            Randomize();
        }
        
        generatePedestal();
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
        int t;
        t = ansarr[a];
        ansarr[a] = ansarr[b];
        ansarr[b] = t;
    }

}
