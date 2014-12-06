using System;
using Xunit;

namespace wmwood.Raj.Tests
{
    public abstract class LoadConfigurationUseCaseTest
    {
        protected readonly LoadConfigurationUseCase UseCase;

        protected LoadConfigurationUseCaseTest()
        {
            UseCase = new LoadConfigurationUseCase();
        }
    }

    [Trait("LoadConfigurationUseCaseTest", "Given An Empty File")]
    public class GivenEmptyFile : LoadConfigurationUseCaseTest
    {
        [Fact(DisplayName = "Throws An Exception")]
        public void ThrowsException()
        {
            using (var emptyFile = new TempFile())
            {
                var path = emptyFile.Path;
                Assert.Throws<InvalidOperationException>(() => UseCase.Load(path));
            }
        }
    }
}