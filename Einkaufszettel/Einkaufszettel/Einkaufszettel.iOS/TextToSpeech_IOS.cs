using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Einkaufszettel.iOS;
using AVFoundation;

[assembly: Dependency(typeof(TextToSpeech_IOS))]
namespace Einkaufszettel.iOS
{
    public class TextToSpeech_IOS
    {
        float volume = 0.5f;
        float pitch = 1.0f;

        public void Speak(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                var speechSynthesizer = new AVSpeechSynthesizer();
                var speechUtterance = new AVSpeechUtterance(text)
                {
                    Rate = AVSpeechUtterance.MaximumSpeechRate / 3,
                    Voice = AVSpeechSynthesisVoice.FromLanguage("de-DE"),
                    Volume = volume,
                    PitchMultiplier = pitch
                };

                speechSynthesizer.SpeakUtterance(speechUtterance);
            }
        }
    }
}