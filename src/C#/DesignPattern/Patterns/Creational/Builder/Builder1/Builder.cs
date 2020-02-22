using System;
using System.Collections.Generic;

namespace DesignPattern.Creational.Builder.Builder1
{
    /// <summary>
    /// TODO
    /// </summary>
    public class Builder : IBuilder
    {
        private Product _product;

        public Builder()
        {
            Reset();
        }

        public void Reset()
        {
            _product = new Product();
        }

        public void BuildPartA()
        {
            this._product.Add("PartA");
        }

        public void BuildPartB()
        {
            this._product.Add("PartB");
        }

        public Product GetProduct()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }
    }
}