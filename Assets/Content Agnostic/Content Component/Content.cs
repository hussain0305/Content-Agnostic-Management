using UnityEngine;
using System.Collections;

/// <summary>
/// This class represents a content domain or subject
/// to be taught by the game. DO NOT modify this class!
/// Instead, your individual content domains should
/// inherit from this class.
/// </summary>
public abstract class Content
{
    // These are both for display purposes.
    public string name { get; protected set; }
    public string description { get; protected set; }

    /// <summary>
    /// This determines whether or not the last action
    /// that the player attempted was valid ro not. This 
    /// will be updated by your hook handlers and the
    /// get method for it will be called by your mechanics
    /// as needed.
    /// </summary>
    protected bool lastActionValid = false;

    // Default constructor
    public Content()
    {
        name = "";
        description = "";
    }

    // Actual constructor, you probably want to override the default and use fixed values.
    public Content(string n, string d)
    {
        name = n;
        description = d;
    }

    // Do not override this! See next method customHook.
    public void acceptHook(Hook hook)
    {
        StudentModel.acceptHook(hook);
        switch (hook.type)
        {
            case HookType.Error:
                errorHook(hook);
                break;
            case HookType.Fail:
                failHook(hook);
                break;
            case HookType.Idle:
                idleHook(hook);
                break;
            case HookType.Input:
                inputHook(hook);
                break;
            case HookType.Success:
                successHook(hook);
                break;
            case HookType.Task:
                taskHook(hook);
                break;
            case HookType.Action:
                actionHook(hook);
                break;
            case HookType.Gameobject:
                gameObjectHook(hook);
                break;
            case HookType.Analytics:
                analyticsHook(hook);
                break;
            default:
                customHook(hook);
                break;
        }
    }

    /// <summary>
    /// If you make a new type of hook, you will need
    /// to override this function. You will want to add
    /// your new type to the switch in here. Do not change
    /// acceptHook above! This way there is a universal 
    /// method for all hooks, regardless of type!
    /// </summary>
    /// <param name="hook">The custom hook to be processed.</param>
    protected virtual void customHook(Hook hook)
    {
        switch (hook.type)
        {
            default:
                Debug.Log("Hook switch defaulted: Unknown hook type received. Did you add a new type and forget to update this?");
                break;
        }
    }

    // Override the ones of these stubs that you actually use.

    protected virtual void actionHook(Hook hook)
    {
        return;
    }

    protected virtual void analyticsHook(Hook hook)
    {
        return;
    }

    protected virtual void errorHook(Hook hook)
    {
        return;
    }

    protected virtual void failHook(Hook hook)
    {
        return;
    }

    protected virtual void gameObjectHook(Hook hook)
    {
        return;
    }

    protected virtual void idleHook(Hook hook)
    {
        return;
    }

    protected virtual void inputHook(Hook hook)
    {
        return;
    }

    protected virtual void successHook(Hook hook)
    {
        return;
    }

    protected virtual void taskHook(Hook hook)
    {
        return;
    }

    /// <summary>
    /// This returns a char representation of something to
    /// be shown to the player that depends on the active
    /// content (ie. a letter or a digit). Override this
    /// with one that returns the proper thing in your
    /// class.
    /// </summary>
    /// <returns></returns>
    public virtual char getItem()
    {
        return '!';
    }

    /// <summary>
    /// This is the same as above, but for longer than
    /// single char strings.
    /// </summary>
    /// <returns></returns>
    public virtual string getTerm()
    {
        return "NULL";
    }

    /// <summary>
    /// Here is where your mechanics can "ask" the content
    /// if the player succeeded or not.
    /// </summary>
    /// <returns></returns>
    public bool wasLastActionValid()
    {
        return lastActionValid;
    }
}