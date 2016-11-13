using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Terminal
{
    public class Input : MonoBehaviour
    {

        InputField input;
        InputField.SubmitEvent submitEvent;
        public Text output;

        // Use this for initialization
        void Start()
        {
            input = gameObject.GetComponent<InputField>();
            submitEvent = new InputField.SubmitEvent();
            submitEvent.AddListener(SubmitInput);
            input.onEndEdit = submitEvent;
        }

        private void SubmitInput(string arg0)
        {
            string history = output.text; // Might need ToString()
            string newText = history + "\n" + arg0;
            output.text = newText;
            input.text = "";
            input.ActivateInputField();
        }
    }
};