using NSubstitute;
using NUnit.Framework;
using Urho;
using UrhoSharp.Interfaces;
using UrhoSharp.Pages;
using UrhoSharp.Pages.InputDeviceAdapters;

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
            var input = Substitute.For<IInput>();
            var adapter = new KeyboardAdapter(input);
            var page = Substitute.For<IScenePage>();
            adapter.AssignPage(page);
            var args = new KeyDownEventArguments(Key.Up, 0, false, 0, 0);
            input.KeyDown += Raise.EventWith(null, args);

            page.Received().OnKeyDown(input, args);
        }

        [Test]
        public void OnKeyDown_NoPage_DoesNotThrow()
        {
            var input = Substitute.For<IInput>();
            var adapter = new KeyboardAdapter(input);

            input.KeyDown += Raise.EventWith(null, new KeyDownEventArguments(Key.Up, 0, false, 0, 0));
        }

        [Test]
        public void OnKeyDown_PageChanged_CorrectPageReceivesCall()
        {
            var input = Substitute.For<IInput>();
            var adapter = new KeyboardAdapter(input);
            var page1 = Substitute.For<IScenePage>();
            var page2 = Substitute.For<IScenePage>();
            adapter.AssignPage(page1);
            adapter.ReleasePage(page1);

            adapter.AssignPage(page2);
            var args = new KeyDownEventArguments(Key.Up, 0, false, 0, 0);
            input.KeyDown += Raise.EventWith(null, args);

            page1.Received(0).OnKeyDown(input, args);
            page2.Received(1).OnKeyDown(input, args);
        }

        [Test]
        public void OnKeyDown_PageDeactivated_KeyCancelMessageReceived()
        {
            var input = Substitute.For<IInput>();
            var adapter = new KeyboardAdapter(input);
            var page1 = Substitute.For<IScenePage>();
            adapter.AssignPage(page1);
            var args = new KeyDownEventArguments(Key.Up, 0, false, 0, 0);
            input.KeyDown += Raise.EventWith(null, args);

            adapter.ReleasePage(page1);

            page1.Received(1).OnKeyCancel(adapter, Arg.Any<KeyCancelEventArguments>());
        }

        [Test]
        public void OnKeyDown_PageDeactivated_PageDoesntReceiveCall()
        {
            var input = Substitute.For<IInput>();
            var adapter = new KeyboardAdapter(input);
            var page1 = Substitute.For<IScenePage>();
            adapter.AssignPage(page1);
            adapter.ReleasePage(page1);

            var args = new KeyDownEventArguments(Key.Up, 0, false, 0, 0);
            input.KeyDown += Raise.EventWith(null, args);

            page1.Received(0).OnKeyDown(input, args);
        }
    }
}