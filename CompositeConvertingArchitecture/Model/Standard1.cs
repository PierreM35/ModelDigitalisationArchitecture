﻿using ModelDigitalisationArchitecture.Abstractions;

namespace ModelDigitalisationArchitecture.Model
{
    public class Standard1() : Standard(1, GetFactoryMethods())
    {
        private static Dictionary<byte, Type> GetFactoryMethods()
            => new()
            {
                { 1, typeof(Container1) },
                { 2, typeof(Container2) }
            };
    }
}
