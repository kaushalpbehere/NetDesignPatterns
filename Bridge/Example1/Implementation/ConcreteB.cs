// <copyright file="ConcreteB.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Bridge.Example1.Implementation
{
    using System;
    using Bridge.Example1.Abstraction;

    internal class ConcreteB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorB Operation");
        }
    }
}