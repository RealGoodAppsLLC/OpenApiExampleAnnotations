// <copyright file="ExampleGeneratorConstructor.Uri.cs" company="Real Good Apps">
// Copyright (c) Real Good Apps. All rights reserved.
// </copyright>

using System;

namespace RealGoodApps.OpenApiExampleAnnotations.Constructors
{
    internal static partial class ExampleGeneratorConstructor
    {
        internal static object ConstructUri(object example)
        {
            if (example == null)
            {
                return null;
            }

            try
            {
                var exampleType = example.GetType();

                if (exampleType == typeof(string))
                {
                    var exampleAsString = (string)example;
                    return new Uri(exampleAsString, UriKind.RelativeOrAbsolute);
                }
            }
            catch (Exception)
            {
                // ignored
            }

            return null;
        }
    }
}
