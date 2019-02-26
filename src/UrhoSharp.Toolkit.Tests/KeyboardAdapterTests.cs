using NSubstitute;
using NUnit.Framework;
using Urho;
using UrhoSharp.Input.InputDeviceAdapters;
using UrhoSharp.Interfaces;
using UrhoSharp.Pages;

namespace UrhoSharp.Toolkit
{
    [TestFixture]
    public class MouseAdapterTests
    {
    }

    [TestFixture]
    public class KeyboardAdapterTests
    {
        [Test]
        public void OnKeyDown_APage_EventSentThrough()
        {
            var adapter = new KeyboardAdapter();
            var page = Substitute.For<IScenePage>();
            adapter.AssignSubscriber(page);
            var args = new KeyDownEventArguments(Key.Up, 0, false, 0, 0);
            adapter.OnKeyDown(null, args);

            page.Received().OnKeyDown(null, args);
        }

        [Test]
        public void OnKeyDown_NoPage_DoesNotThrow()
        {
            var adapter = new KeyboardAdapter();

            adapter.OnKeyDown(null, new KeyDownEventArguments(Key.Up, 0, false, 0, 0));
        }

        [Test]
        public void OnKeyDown_PageChanged_CorrectPageReceivesCall()
        {
            var adapter = new KeyboardAdapter();
            var page1 = Substitute.For<IScenePage>();
            var page2 = Substitute.For<IScenePage>();
            adapter.AssignSubscriber(page1);
            adapter.ReleaseSubscriber(page1);

            adapter.AssignSubscriber(page2);
            var args = new KeyDownEventArguments(Key.Up, 0, false, 0, 0);
            adapter.OnKeyDown(null, args);

            page1.Received(0).OnKeyDown(null, args);
            page2.Received(1).OnKeyDown(null, args);
        }

        [Test]
        public void OnKeyDown_PageDeactivated_KeyCancelMessageReceived()
        {
            var adapter = new KeyboardAdapter();
            var page1 = Substitute.For<IScenePage>();
            adapter.AssignSubscriber(page1);
            var args = new KeyDownEventArguments(Key.Up, 0, false, 0, 0);
            adapter.OnKeyDown(null, args);

            adapter.ReleaseSubscriber(page1);

            page1.Received(1).OnKeyCancel(adapter, Arg.Any<KeyCancelEventArguments>());
        }

        [Test]
        public void OnKeyDown_PageDeactivated_PageDoesntReceiveCall()
        {
            var adapter = new KeyboardAdapter();
            var page1 = Substitute.For<IScenePage>();
            adapter.AssignSubscriber(page1);
            adapter.ReleaseSubscriber(page1);

            var args = new KeyDownEventArguments(Key.Up, 0, false, 0, 0);
            adapter.OnKeyDown(null, args);

            page1.Received(0).OnKeyDown(null, args);
        }
    }
}