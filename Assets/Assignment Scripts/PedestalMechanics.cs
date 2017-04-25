using UnityEngine;
using System.Collections;

public class PedestalMechanics : Mechanics
{
    // Use this for initialization
    public void sendHook(string c, string cs)
    {
        passHook(new CompareHook(c, cs));
    }
}
