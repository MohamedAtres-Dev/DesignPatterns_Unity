using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern
{
    public class CSharpObserver : MonoBehaviour
    {
        //Void Type of delegate
        public delegate void VoidDelegate();
        public static VoidDelegate onVoidDelegate;

        //Return Type of delegate
        public delegate int IntDelegate();
        public static IntDelegate onIntDelegate;

        //Taking parmetares Type of delegate
        public delegate void ParmDelegate(string parm1);
        public static event ParmDelegate onParmDelegate;


        //using Action
        public static Action onDoingAction;
        public static Action<string> onSendString;

        //using Func
        public static Func<string, string> onSendingScore;


        public void InvokeDelegate()
        {
            onVoidDelegate?.Invoke();

            onIntDelegate?.Invoke();

            onParmDelegate?.Invoke("This is c# string Delegate");
        }


        public void InvokeActions()
        {
            onDoingAction?.Invoke();

            onSendString?.Invoke("This is c# string Action");
        }

        public void InvokeFunc()
        {
            onSendingScore?.Invoke("This is c# string Func");
        }

        
    }
}