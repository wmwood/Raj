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
}