using UnityEngine;
using System.Collections;

public class ContentDDM : Content
{


    private string[] questions = { "The Ball is kept over _____",
        "We had a few neighbours move in next door. We love ___ Car ",
        "Mike and Chris think Santa is real. ___ are going to be disappinted when they find out the truth ", //0-2
        "___ rhymes with tough",
        "___rhymes with though",
        "___ rhymes with through",
        "cough rhymes with ___", //3-6
        "The closest synonym of ____ is extraordinary",
        "The closest synonym of ____ is furious",
        "Dangerous means the same as ____",
        "Alfred nodded saying he was positive about the instructions. He meant he was ____",
        "Matt wanted to go the park. He was ___ to meet his friends", // in 11
        "peevish is the synonym for ___" };
    private int[] answers = { 7, 8, 3, 4, 5 };
    private string[] answers2 = { "there",
        "their",
        "they're",
        "rough",
        "bow",
        "brew",
        "scoff",
        "astounding",
        "anger" ,
        "perilous",
        "sure",
        "eager" ,
        "temperamental" };

    public ContentDDM()
    {
        name = "English Language Nuances"; 
        description = "Read rhymes with lead, and read rhymes with lead, but read and lead don’t rhyme, and neither do read and lead.";
    }

    public string getQuestion(int i)
    {
        return questions[i];
    }
    public string getAnswer(int i) //CHANGE 2 IN THE RETURN TYPE
    {
        return answers2[i]; //CHANGE 1
    }

    public override string getTerm()
    {
        // Implementation here for random multiplicand and multiplier
        return "Fill in the blanks";
    }

    protected override void customHook(Hook hook)
    {
        switch (hook.type)
        {
            case HookType.Compare:
                compareHook((CompareHook)hook);
                break;
            default:
                base.customHook(hook);
                break;
        }
    }

    private void compareHook(CompareHook hook)
    {
        Debug.Log(hook.input + "++" + hook.compareTo);

        lastActionValid = (hook.input == hook.compareTo);
    }

}
