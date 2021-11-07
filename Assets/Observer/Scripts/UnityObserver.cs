using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace ObserverPattern
{
    public class UnityObserver : MonoBehaviour
    {
        public UnityEvent onInvokeEvent; 
        public UnityEvent<string> onInvokeStringEvent;

        public static UnityAction onInvokeAction = delegate { }; 
        public static UnityAction<string> onInvokeStringAction = delegate { };


        //the difference between UnityEvent and UnityAction is UnityEvent can be serialzed in the inspector.

        public void InvokeEvents()
        {
            onInvokeEvent?.Invoke();

           
        }

        public void InvokeStringEvents()
        {
            onInvokeStringEvent?.Invoke("Unity Event is Invoked");
        }

        public void InvokeActions()
        {
            onInvokeAction.Invoke();

            
        }

        public void InvokeStringAction()
        {
            onInvokeStringAction.Invoke("Unity Action is Invoked");
        }
    }
}