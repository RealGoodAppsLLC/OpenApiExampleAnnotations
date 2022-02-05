// <copyright file="ExampleGeneratorConstructor.Bool.cs" company="Real Good Apps">
// Copyright (c) Real Good Apps. All rights reserved.
// </copyright>

using System;

namespace RealGoodApps.OpenApiExampleAnnotations.Constructors
{
    internal static partial class ExampleGeneratorConstructor
    {
        internal static object ConstructBool(
            object example,
            bool isNullable)
        {
            object @default = false;

            if (isNullable)
            {
                @default = null;
            }

            if (example == null)
            {
                return @default;
            }

            try
            {
                var exampleType = example.GetType();

                if (exampleType != typeof(bool))
                {
                    return Convert.ToBoolean(example);
                }

                var exampleAsBool = (bool)example;
                return exampleAsBool;
            }
            catch (Exception)
            {
                // ignored
            }

            return @default;
        }
    }
}
