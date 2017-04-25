using UnityEngine;
using System.Collections;

public class MathContent : Content
{
    private char[] nums = {'1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};

    public MathContent()
    {
        name = "Math";
        description = "Hate numbers? Blast them to bits!";
    }

    public override char getItem()
    {
        return nums[Random.Range(0, nums.Length)];
    }

    public override string getTerm()
    {
        return "Shoot the lowest number!";
    }

    protected override void customHook(Hook hook)
    {
        switch(hook.type)
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
        //bool smallest = true;
        //for(int i = 0; i < hook.compares.Length; i++)
        //{
        //    if(hook.compares[i] < hook.input)
        //    {
        //        smallest = false;
        //    }
        //}
        //if(smallest)
        //{
        //    lastActionValid = true;
        //}
        //else
        //{
        //    lastActionValid = false;
        //}
    }
}
