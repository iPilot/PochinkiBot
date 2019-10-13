﻿using System;

namespace PochinkiBot.Client.Commands
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public class CommandArgAttribute : Attribute
    {
        public string Name { get; }
        public Type Type { get; }
        public object DefaultValue { get; }

        public CommandArgAttribute(string name, Type type, object defaultValue = null)
        {
            Name = name;
            Type = type;
            DefaultValue = defaultValue;
            if (defaultValue != null && defaultValue.GetType() != type)
                throw new ArgumentException("Invalid defaultValue", nameof(defaultValue));
        }
    }
}