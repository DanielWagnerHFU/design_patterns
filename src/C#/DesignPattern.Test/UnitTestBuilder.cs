using System;
using Xunit;
using DesignPattern.Creational.Builder.Builder1;

namespace DesignPattern.Test
{
    public class UnitTestBuilder
    {
        [Fact]
        public void BuilderTest1()
        {
            Director director = new Director();
            Builder builder = new Builder();
            director.Builder = builder;
            director.BuildMinimalViableProduct();
            Assert.Equal("Product parts: PartA", builder.GetProduct().ListParts());
        }

        [Fact]
        public void BuilderTest2()
        {
            Director director = new Director();
            Builder builder = new Builder();
            director.Builder = builder;
            director.BuildFullFeaturedProduct();
            Assert.Equal("Product parts: PartA, PartB", builder.GetProduct().ListParts());
        }

        [Fact]
        public void BuilderTest3()
        {
            Builder builder = new Builder();
            builder.BuildPartB();
            Assert.Equal("Product parts: PartB", builder.GetProduct().ListParts());
        }
    }
}