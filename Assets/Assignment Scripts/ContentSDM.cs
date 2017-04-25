using UnityEngine;
using System.Collections;

public class ContentSDM : Content {


    private string[] questions = { "3x = 21",
        "7x = 56. ",
        "2x + 3 = 9 ",
        "11x + 24 = 68 ",
        "If y=2, and 3x + 4y = 23 ",
        "y = 2x + 1 & y=5",
        "5x = 6 + 3y & y = 8",
        "f(x) = 2x − 3 & value of function is 15",
        "f(x) = 4x +13 & value of function is 57",
        "5x - 12 = 3x + 6",
        "4(x+1) = 20",
        "6(x+y) = 48 + 6y",
        "f(x) = f(y) + 2 & f(y) = 2y+3. Find for y=2",
        "f(x) = 2x + 7 & value of function is 21",
        "f(x) = 3x + 11 & value of function is 47" };
    private int[] answers = { 7, 8, 3, 4, 5, 2, 6, 9, 11, 9, 4, 12, 9, 7, 12 };
    

    public ContentSDM()
    {
        name = "Linear Equations";
        description = "If you and your friend have 4 apples, how many does each get ? Find out! ";
    }

    public string getQuestion(int i)
    {
        return questions[i];
    }
    public int getAnswer(int i)
    {
        return answers[i];
    }

    public override string getTerm()
    {
        // Implementation here for random multiplicand and multiplier
        return "Find x in the equation below";
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
