using System;
using Xunit;

namespace TestStack.BDDfy.Tests.Scanner.ReflectiveScanner
{
    public class PropertiesAreNotConsideredAsStepsEvenWhenTheirNameMatchesConventions
    {
        // It has to end with context to fulfil the convention; after compilation this property will be get_GivenblahblahContext
        protected int GivenThePropertyNameFulfillsTheConventionsContext
        {
            get { throw new InvalidOperationException("This should not have been called"); }
            set { throw new InvalidOperationException("This should not have been called"); }
        }

        public int GivenThePublicPropertyNameFulfillsTheConventionsContext
        {
            get { throw new InvalidOperationException("This should not have been called"); }
            set { throw new InvalidOperationException("This should not have been called"); }
        }

        static int GivenTheStaticPropertyNameFulfillsTheConventionsContext
        {
            get { throw new InvalidOperationException("This should not have been called"); }
            set { throw new InvalidOperationException("This should not have been called"); }
        }

        void ThenThePropertyShouldBeAvoided()
        {
        }

        [Fact]
        public void Execute()
        {
            this.BDDfy();
        }
    }
}