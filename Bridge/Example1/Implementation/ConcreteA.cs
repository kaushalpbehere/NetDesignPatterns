// <copyright file="ConcreteA.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Bridge.Example1.Implementation
{
    using System;
    using Bridge.Example1.Abstraction;

    public class ConcreteA : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorA Operation");
        }
    }
}