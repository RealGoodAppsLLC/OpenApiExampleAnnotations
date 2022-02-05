// <copyright file="Example.cs" company="Real Good Apps">
// Copyright (c) Real Good Apps. All rights reserved.
// </copyright>

using System;

namespace RealGoodApps.OpenApiExampleAnnotations.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class Example : Attribute
    {
        public object Key { get; }
        public object Value { get; }

        public Example(object value)
        {
            Key = null;
            Value = value;
        }

        public Example(object key, object value)
        {
            Key = key;
            Value = value;
        }
    }
}
