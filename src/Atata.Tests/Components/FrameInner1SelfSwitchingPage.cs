﻿using OpenQA.Selenium;
using _ = Atata.Tests.FrameInner1SelfSwitchingPage;

namespace Atata.Tests
{
    [Name("Frame Inner 1")]
    [VerifyH1]
    public class FrameInner1SelfSwitchingPage : Page<_>
    {
        public H1<_> Header { get; private set; }

        public TextInput<_> TextInput { get; private set; }

        protected override void OnInit()
        {
            base.OnInit();

            IWebElement iframe = Driver.Get(By.XPath(".//iframe[@id='iframe-1']"));
            Driver.SwitchTo().Frame(iframe);
        }

        protected override void CleanUp()
        {
            base.CleanUp();

            Driver.SwitchTo().DefaultContent();
        }
    }
}
