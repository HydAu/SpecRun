﻿using FluentAssertions;
using NUnit.Framework;
using TechTalk.SpecFlow.Assist.ValueRetrievers;
using Moq;
using TechTalk.SpecFlow.Bindings;
using System.Collections.Generic;
using System.Globalization;
using TechTalk.SpecFlow.Infrastructure;
using TechTalk.SpecFlow.Tracing;
using System;

namespace TechTalk.SpecFlow.RuntimeTests.AssistTests.ValueRetrieverTests
{
    [TestFixture]
    public class StepTransformationValueRetrieverTests
    {

        [Test]
        public void Convert_will_return_the_value_from_the_step_argument_type_converter()
        {
            var dateTimeResult = Subject().Retrieve(KeyValueFor("2009/10/06"), typeof(DateTime));
            dateTimeResult.Should().Be(new DateTime(2009, 10, 6));

            var stringResult = Subject().Retrieve(KeyValueFor("2009/10/06"), typeof(string));
            stringResult.Should().Be("2009/10/06");
        }

        private KeyValuePair<string, string> KeyValueFor(string value)
        {
            // retrieving a value requires a key->value set, but this class
            // does not need the key... so we pass nothing for our tests
            return new System.Collections.Generic.KeyValuePair<string, string> ("", value);
        }

        private StepTransformationValueRetriever Subject()
        {
            // have to set up a container with a bunch of mocked stuff
            // in order to build a StepArgumentTypeConverter
            var container = new BoDi.ObjectContainer();

            var provider = new TechTalk.SpecFlow.Infrastructure.DefaultDependencyProvider();
            provider.RegisterTestRunnerDefaults(container);

            Mock<IBindingRegistry> bindingRegistryStub = new Mock<IBindingRegistry>();
            List<IStepArgumentTransformationBinding> stepTransformations = new List<IStepArgumentTransformationBinding>();
            bindingRegistryStub.Setup(br => br.GetStepTransformations()).Returns(stepTransformations);
            Mock<IBindingInvoker> methodBindingInvokerStub = new Mock<IBindingInvoker>();

            var stepArgumentTypeConverter = new StepArgumentTypeConverter(new Mock<ITestTracer>().Object, bindingRegistryStub.Object, new Mock<IContextManager>().Object, methodBindingInvokerStub.Object);

            // need a culture info as well
            var cultureInfo = new CultureInfo("en-US");

            // load them into the container
            container.RegisterInstanceAs<IStepArgumentTypeConverter>(stepArgumentTypeConverter);
            container.RegisterInstanceAs<CultureInfo>(cultureInfo);

            // now we have what we need to get a our subject, loaded
            // with a fake source for all of its dependencies
            var retriever = new StepTransformationValueRetriever();
            retriever.Container = container;
            return retriever;
        }

    }
}