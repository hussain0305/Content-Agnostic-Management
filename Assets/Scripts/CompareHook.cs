using UnityEngine;
using System.Collections;

public class CompareHook : Hook
{
    public string input { get; private set; }
    public string compareTo { get; private set; }

    public CompareHook(string inp, string compareTo)
    {
        input = inp;
        this.compareTo = compareTo;
        type = HookType.Compare;
    }

    public override string ToString()
    {
        string str = "Compare " + input + " to: " + compareTo;
        return base.ToString();
    }
}
