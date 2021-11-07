using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ObserverPattern;
using UnityEngine.UI;
using TMPro;

public class MainListener : MonoBehaviour
{
    public TextMeshProUGUI infoText;


    //Subscribe to events
    private void OnEnable()
    {
        UnityObserver.onInvokeAction += ListenToVoidAction;
        UnityObserver.onInvokeStringAction += ListenToStringAction;


        CSharpObserver.onVoidDelegate += ListenToVoidAction;
        CSharpObserver.onIntDelegate += ListenToIntDelegate;
        CSharpObserver.onParmDelegate += ListenToStringAction;
        CSharpObserver.onDoingAction += ListenToVoidAction;
        CSharpObserver.onSendString += ListenToStringAction;
        CSharpObserver.onSendingScore += ListenToFunc;

    }

    private void OnDisable()
    {
        UnityObserver.onInvokeAction -= ListenToVoidAction;
        UnityObserver.onInvokeStringAction -= ListenToStringAction;


        CSharpObserver.onVoidDelegate -= ListenToVoidAction;
        CSharpObserver.onIntDelegate -= ListenToIntDelegate;
        CSharpObserver.onParmDelegate -= ListenToStringAction;
        CSharpObserver.onDoingAction -= ListenToVoidAction;
        CSharpObserver.onSendString -= ListenToStringAction;
        CSharpObserver.onSendingScore -= ListenToFunc;

    }


    public void ListenToVoidAction()
    {
        infoText.text = "This is a void ";
    }


    public void ListenToStringAction(string text)
    {
        infoText.text = text;
    }


    public int ListenToIntDelegate()
    {
        Debug.Log("Listen to int delegate ");
        return 10;
    }

    public string ListenToFunc(string text)
    {
        infoText.text = text;
        return text;
    }
}
