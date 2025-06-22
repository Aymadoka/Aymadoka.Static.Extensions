using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.EventHandlerExtension
{
    public class EventHandler_RaiseEventTests
    {
        [Fact]
        public void RaiseEvent_NoSender_EventIsRaised()
        {
            bool raised = false;
            EventHandler handler = (s, e) => raised = true;

            handler.RaiseEvent(EventArgs.Empty);

            Assert.True(raised);
        }

        [Fact]
        public void RaiseEvent_WithSender_EventIsRaisedWithCorrectSender()
        {
            object expectedSender = new object();
            object actualSender = null;
            EventHandler handler = (s, e) => actualSender = s;

            handler.RaiseEvent(expectedSender, EventArgs.Empty);

            Assert.Equal(expectedSender, actualSender);
        }

        [Fact]
        public void RaiseEvent_Generic_WithSender_EventArgsIsCreated()
        {
            object expectedSender = new object();
            object actualSender = null;
            TestEventArgs actualArgs = null;
            EventHandler<TestEventArgs> handler = (s, e) =>
            {
                actualSender = s;
                actualArgs = e;
            };

            handler.RaiseEvent<TestEventArgs>(expectedSender);

            Assert.Equal(expectedSender, actualSender);
            Assert.NotNull(actualArgs);
        }

        [Fact]
        public void RaiseEvent_Generic_WithSenderAndArgs_EventIsRaisedWithCorrectArgs()
        {
            object expectedSender = new object();
            var expectedArgs = new TestEventArgs { Value = 42 };
            object actualSender = null;
            TestEventArgs actualArgs = null;
            EventHandler<TestEventArgs> handler = (s, e) =>
            {
                actualSender = s;
                actualArgs = e;
            };

            handler.RaiseEvent(expectedSender, expectedArgs);

            Assert.Equal(expectedSender, actualSender);
            Assert.Equal(expectedArgs, actualArgs);
        }

        [Fact]
        public void RaiseEvent_NullHandler_DoesNotThrow()
        {
            EventHandler handler = null;
            handler.RaiseEvent(EventArgs.Empty);
        }

        [Fact]
        public void RaiseEvent_Generic_NullHandler_DoesNotThrow()
        {
            EventHandler<TestEventArgs> handler = null;
            handler.RaiseEvent(new object(), new TestEventArgs());
        }

        [ExcludeFromCodeCoverage]
        public class TestEventArgs : EventArgs
        {
            public int Value { get; set; }
        }
    }
}
