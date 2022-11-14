using Android.App;
using Android.InputMethodServices;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.App;
using Java.Lang;

namespace CustomKeyboardDemo
{
    [Service(Permission = "android.permission.BIND_INPUT_METHOD", Label = "CUSTOMKEYBOARD", Exported = true)]
    [MetaData("android.view.im", Resource = "@xml/method")]
    [IntentFilter(new string[]{"android.view.InputMethod"})]
    [System.Obsolete]
    public class MainActivity : InputMethodService, KeyboardView.IOnKeyboardActionListener
    {
        private KeyboardView _keyboardView;
        private Keyboard _keyboard;
        private bool isCaps = false;

        public override View OnCreateInputView()
        {
            _keyboardView = (KeyboardView)LayoutInflater.Inflate(Resource.Layout.activity_main, null);
            _keyboard = new Keyboard(this, Resource.Xml.Qwerty);
            _keyboardView.Keyboard = _keyboard;
            _keyboardView.OnKeyboardActionListener = this;

            return _keyboardView;
        }
        public void OnKey([GeneratedEnum] Android.Views.Keycode primaryCode, [GeneratedEnum] Android.Views.Keycode[] keyCodes)
        {
           
                   
               
        }

        public void OnPress([GeneratedEnum] Android.Views.Keycode primaryCode)
        {
     
        }

        public void OnRelease([GeneratedEnum] Android.Views.Keycode primaryCode)
        {
        
        }

        public void OnText(ICharSequence text)
        {
            
        }

        public void SwipeDown()
        {
           
        }

        public void SwipeLeft()
        {
           
        }

        public void SwipeRight()
        {
           
        }

        public void SwipeUp()
        {
            
        }
    }
}