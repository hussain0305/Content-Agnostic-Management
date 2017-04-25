using UnityEngine;
using System.Collections;

public class PedestalTriggerTwo : MonoBehaviour
{

    public PedestalManagerTwo pm;
    public GameObject res;
    

    void OnTriggerEnter(Collider col)
    {
        print("Triggered by" + col.gameObject);
        PedestalMechanics temp = (PedestalMechanics)GameInfo.currentMechanics;
        print(gameObject.GetComponent<TextMesh>().text + " -- " + pm.pedestalA.ToString());
        temp.sendHook(gameObject.GetComponent<TextMesh>().text, pm.pedestalA.ToString());

        if (FrameworkCore.currentContent.wasLastActionValid())
        {
            print("Valid");
            res.SetActive(true);
            res.GetComponent<TextMesh>().text = "Correct! Restarting Level";
            res.GetComponent<TextMesh>().color = Color.green;
            StartCoroutine(DelayRestart(1));


        }
        else
        {
            print("Invalid");
            res.SetActive(true);
            res.GetComponent<TextMesh>().text = "Incorrect!!!";
            res.GetComponent<TextMesh>().color = Color.red;
            StartCoroutine(DelayRestart2(1));
        }
    }

    IEnumerator DelayRestart(float time)
    {
        yield return new WaitForSeconds(time);

        Application.LoadLevel(Application.loadedLevel);
    }

    IEnumerator DelayRestart2(float time)
    {
        yield return new WaitForSeconds(time);
        res.SetActive(false);
    }
}