using System;
using NSubstitute;
using NUnit.Framework;
using Urho;
using UrhoSharp.Pages;
using UrhoSharp.Pages.InputDeviceAdapters;
using UrhoSharp.Interfaces;

namespace UrhoSharp.Toolkit
{
    [TestFixture]
    public class KeyboardAdapterTests
    {
        [Test]
        public void GenCode()
        {
            var t = typeof(Input);
            Func<string, string> lowerFirst = _ => _.Substring(0, 1).ToLower() + _.Substring(1);
            foreach (var eventInfo in t.GetEvents())
            {
                var argType = eventInfo.EventHandlerType.GetGenericArguments()[0];

                var urhoArgsType = argType.Name;
                var inputArgsType = argType.Name.Replace("Args", "Arguments");

                var backFieldName = "_" + lowerFirst(eventInfo.Name);

                Console.WriteLine("        private EventHandler<" + inputArgsType + "> " + backFieldName + ";");
                Console.WriteLine("        public event EventHandler<" + inputArgsType + "> " + eventInfo.Name);
                Console.WriteLine("        {");
                Console.WriteLine("            add");
                Console.WriteLine("            {");
                Console.WriteLine("                if (" + backFieldName + " == null)");
                Console.WriteLine("                    _input." + eventInfo.Name + " += On" + eventInfo.Name + "; ");
                Console.WriteLine("                " + backFieldName + " += value;");
                Console.WriteLine("            }");
                Console.WriteLine("            remove");
                Console.WriteLine("            {");
                Console.WriteLine("                " + backFieldName + " -= value;");
                Console.WriteLine("                if (" + backFieldName + " == null)");
                Console.WriteLine("                    _input." + eventInfo.Name + " -= On" + eventInfo.Name + ";");
                Console.WriteLine("            }");
                Console.WriteLine("        }");

                Console.WriteLine("        private void On" + eventInfo.Name + "(" + urhoArgsType + " args)");
                Console.WriteLine("        {");
                Console.WriteLine("            " + backFieldName + "?.Invoke(this, new " + inputArgsType + "(args));");
                Console.WriteLine("        }");
            }
        }

        [Test]
        public void GenCode2()
        {
            var t = typeof(Input);
            foreach (var eventInfo in t.GetEvents())
            {
                var argType = eventInfo.EventHandlerType.GetGenericArguments()[0];

                var urhoArgsType = argType.Name;
                var inputArgsType = argType.Name.Replace("Args", "Arguments");

                var properties = argType.GetProperties();

                Console.WriteLine("    public class " + inputArgsType + " : EventArgs");
                Console.WriteLine("    {");
                Console.WriteLine("        public " + inputArgsType + "(" + urhoArgsType + " args)");
                Console.WriteLine("        {");
                foreach (var propertyInfo in properties)
                    Console.WriteLine("            " + propertyInfo.Name + " = args." + propertyInfo.Name + ";");
                Console.WriteLine("        }");
                foreach (var propertyInfo in properties)
                    Console.WriteLine("        public " + propertyInfo.PropertyType.Name + " " + propertyInfo.Name +
                                      " { get; }");
                Console.WriteLine("    }");
                Console.WriteLine("");
            }
        }

        [Test]
        public void GenCode3()
        {
            var t = typeof(Input);
            Func<string, string> lowerFirst = _ => _.Substring(0, 1).ToLower() + _.Substring(1);
            foreach (var eventInfo in t.GetEvents())
            {
                var argType = eventInfo.EventHandlerType.GetGenericArguments()[0];

                var inputArgsType = argType.Name.Replace("Args", "Arguments");

                Console.WriteLine("        event EventHandler<" + inputArgsType + "> " + eventInfo.Name + ";");
            }
        }

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