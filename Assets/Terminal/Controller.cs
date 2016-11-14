using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Terminal
{
    public class Controller : MonoBehaviour
    {

        public InputField inputField;
        public Text outputText;

        InputField.SubmitEvent submitEvent;

        // Use this for initialization
        void Start()
        {
            submitEvent = new InputField.SubmitEvent();
            submitEvent.AddListener(SubmitInput);
            inputField.onEndEdit = submitEvent;
        }

        private void SubmitInput(string arg0)
        {           
            // Ignore blank string
            if (arg0 == "")
            {
                return;
            }

            string history = outputText.text; // Might need ToString()
            string newText = history + "\n" + arg0;
            outputText.text = newText;
            inputField.text = "";
            inputField.ActivateInputField();
        }
    }
}
