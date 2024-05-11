using System;
using System.Collections.Generic;

namespace ScriptureMemorizingProgram
{
    class Scripture
    {
        private Reference _reference;
        private List<Word> _words;
        private Random _random;

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = new List<Word>();
            _random = new Random();

            string[] splitText = text.Split(new char[] { ' ', '.', ',', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string wordText in splitText)
            {
                _words.Add(new Word(wordText));
            }
        }

        public void HideRandomWords(int numberToHide)
        {

            for (int i = 0; i < numberToHide; i++)
            {
                int index = _random.Next(_words.Count);
                _words[index].Hide();
            }
        }

        public string GetDisplayText()
        {
            string displayText = _reference.GetDisplayText() + "\n";
            foreach (Word word in _words)
            {
                displayText += word.GetDisplayText() + " ";
            }
            return displayText;
        }

        public bool IsCompletelyHidden()
        {
            foreach (Word word in _words)
            {
                if (!word.IsHidden())
                    return false;
            }
            return true;
        }
    }
}
