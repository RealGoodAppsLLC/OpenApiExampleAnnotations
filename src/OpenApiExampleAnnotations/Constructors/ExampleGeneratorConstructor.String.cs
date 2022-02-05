// <copyright file="ExampleGeneratorConstructor.String.cs" company="Real Good Apps">
// Copyright (c) Real Good Apps. All rights reserved.
// </copyright>

using System;
using System.Globalization;

namespace RealGoodApps.OpenApiExampleAnnotations.Constructors
{
    internal static partial class ExampleGeneratorConstructor
    {
        internal static object ConstructString(object example)
        {
            if (example == null)
            {
                return null;
            }

            try
            {
                var exampleType = example.GetType();

                if (exampleType != typeof(string))
                {
                    return Convert.ToString(example, CultureInfo.InvariantCulture);
                }

                var exampleAsString = (string)example;
                return exampleAsString;
            }
            catch (Exception)
            {
                // ignored
            }

            return null;
        }
    }
}
