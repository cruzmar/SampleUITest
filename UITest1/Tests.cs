using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest1
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }

        [Test]
        public void EnterValue()
        {
            enterValues();
            //app.Query()
        }

        [Test]
        public void HitButton()
        {
            enterValues();

            Task.Delay(3000);
            app.Tap("BUTTON_Button1");
        }

        private void enterValues()
        {
            app.EnterText("ENTRY_Entry1", "10");
            app.EnterText("ENTRY_Entry2", "20");
        }
    }
}

