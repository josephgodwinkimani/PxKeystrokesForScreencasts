using System;
using System.Windows.Forms;

namespace PxKeystrokesUi
{
    class SpecialkeysParser
    {
        public static string ToString(Keys k)
        {
            switch(k){
                case Keys.Shift:
                case Keys.ShiftKey:
                case Keys.LShiftKey:
                case Keys.RShiftKey:
                    return "⇧ RIGHT SHIFT";
                case Keys.Control:
                case Keys.ControlKey:
                case Keys.LControlKey:
                case Keys.RControlKey:
                    return "CTRL";
                case Keys.LWin:
                case Keys.RWin:
                    return "WIN";
                case Keys.Menu:
                case Keys.LMenu:
                case Keys.RMenu:
                    return "ALT";
                case Keys.CapsLock:
                    return "⇪ CAPSLOCK";
                case Keys.LineFeed:
                case Keys.Return:
                    return " ⏎ ENTER";
                case Keys.Back:
                    return " ⌫ BACKSPACE";
                case Keys.Left:
                    return " ← LEFT";
                case Keys.Right:
                    return " → RIGHT";
                case Keys.Down:
                    return " ↓ DOWN";
                case Keys.Up:
                    return " ↑ UP";
                case Keys.Escape:
                    return " ESC ";
                case Keys.PrintScreen:
                    return " PRINT ";
                case Keys.Pause:
                    return " PAUSE ";
                case Keys.Insert:
                    return " INSERT ";
                case Keys.Delete:
                    return " DELETE ";


                case Keys.Tab:
                    return "↹ TAB";
                case Keys.Space:
                    return "␣ SPACE";
                case Keys.PageUp: 
                    return " ↖ PAGE UP ";
                case Keys.PageDown:
                     return " ↘ PAGE DOWN";
                case Keys.End:
                    return " ⇲ END";
                case Keys.Home:
                    return " ⇱ HOME";
                case Keys.Print:
                    return " ⎙ PRINT";

                case Keys.Clear:
                case Keys.ProcessKey:
                case Keys.Attn:
                case Keys.Crsel:
                case Keys.Exsel:
                case Keys.EraseEof:
                case Keys.Cancel:
                case Keys.Select:
                case Keys.Execute:
                case Keys.Help:
                case Keys.Apps:
                case Keys.Pa1:
                case Keys.Sleep:
                    return " [" + k.ToString() + "] ";

                case Keys.Multiply:
                    return "* ASTERISK";
                case Keys.Add:
                    return "+ PLUS";
                case Keys.Separator:
                    return " SEPARATOR ";
                case Keys.Subtract:
                    return "- SUBTRACT";
                case Keys.Decimal:
                    return ". PERIOD";
                case Keys.Divide:
                    return "/ DIVIDE";
                case Keys.NumLock:
                    return " NUMLOCK ";
                case Keys.Scroll:
                    return " SCROLL LOCK ";

                case Keys.BrowserBack:
                    return " [🌐⇦] BACK ";
                case Keys.BrowserForward:
                    return " [🌐⇨] FORWARD ";
                case Keys.BrowserRefresh:
                    return " [🌐↻] REFRESH";
                case Keys.BrowserStop:
                    return " [🌐✋] STOP";
                case Keys.BrowserSearch:
                    return " [🌐🔎] SEARCH";
                case Keys.BrowserFavorites:
                    return " [🌐★] FAVORITES";
                case Keys.BrowserHome:
                    return " [🌐⌂] HOME";

          
                case Keys.VolumeMute:
                    return " 🔇 MUTE ";
                case Keys.VolumeDown:
                    return " 🔉⏬ VOLUME DOWN ";
                case Keys.VolumeUp:
                    return " 🔊⏫ VOLUME UP";
                case Keys.MediaNextTrack:
                    return " ⏭ NEXT TRACK";
                case Keys.MediaPreviousTrack:
                    return " ⏮ PREV TRACK";
                case Keys.MediaStop:
                    return " ◼ STOP";
                case Keys.MediaPlayPause:
                    return " ⏯ PAUSE";
                case Keys.LaunchMail:
                    return " 📧 MAIL";
                case Keys.SelectMedia:
                    return " ♪ MEDIA";
                case Keys.LaunchApplication1:
                    return " ① LAUNCH APP 1";
                case Keys.LaunchApplication2:
                    return " ② LAUNCH APP 2";

                case Keys.Play:
                    return " ▶ PLAY";
                case Keys.Zoom:
                    return " [🔎±] ZOOM";
                

            }
            if(Keys.F1 <= k && k <= Keys.F24)
                return " " + k.ToString() + " ";

            throw new NotImplementedException();
        }
    }
}
