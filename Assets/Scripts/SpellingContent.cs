using UnityEngine;
using System.Collections;

public class SpellingContent : Content
{
    private char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };

    public SpellingContent()
    {
        name = "Spelling";
        description = "Make words work for you! Or die. That works too.";
    }

    public override char getItem()
    {
        return letters[Random.Range(0, letters.Length)];
    }

    public override string getTerm()
    {
        return "Shoot a Vowel!";
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
        //bool vowel = false;
        //if(hook.input == 'A' || hook.input == 'E' || hook.input == 'I')
        //{
        //    vowel = true;
        //}
        //if (vowel)
        //{
        //    lastActionValid = true;
        //}
        //else
        //{
        //    lastActionValid = false;
        //}
    }
}
