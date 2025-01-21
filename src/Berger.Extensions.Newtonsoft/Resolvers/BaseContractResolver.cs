﻿using System.Linq.Expressions;
using Newtonsoft.Json.Serialization;

namespace Berger.Extensions.Newtonsoft
{
    public class BaseContractResolver<T> : DefaultContractResolver
    {
        private readonly Dictionary<string, string> _properties = new();

        public BaseContractResolver<T> Map<TProperty>(Expression<Func<T, TProperty>> property, string jsonPropertyName)
        {
            if (property.Body is MemberExpression memberExpression)
            {
                _properties[memberExpression.Member.Name] = jsonPropertyName;
            }
            else
            {
                throw new InvalidOperationException("Only member expressions are supported.");
            }

            return this;
        }
        protected override string ResolvePropertyName(string property)
        {
            return _properties.TryGetValue(property, out var jsonPropertyName)? jsonPropertyName : base.ResolvePropertyName(property);
        }
    }
}