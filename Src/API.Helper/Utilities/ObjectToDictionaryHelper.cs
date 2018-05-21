using System.Collections.Generic;
using System.ComponentModel;

namespace Syncfusion.Report.Server.Api.Helper.Utilities
{
    public static class ObjectToDictionaryHelper
    {
        //http://stackoverflow.com/questions/11576886/how-to-convert-object-to-dictionarytkey-tvalue-in-c
        public static Dictionary<string, object> ToDictionary(this object source)
        {
            var dictionary = source as Dictionary<string, object>;
            return dictionary ?? source.ToDictionary<object>();
        }

        public static Dictionary<string, T> ToDictionary<T>(this object source)
        {
            if (source == null) return null;

            var dictionary = new Dictionary<string, T>();
            foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(source))
                AddPropertyToDictionary(property, source, dictionary);
            return dictionary;
        }

        private static void AddPropertyToDictionary<T>(PropertyDescriptor property, object source, Dictionary<string, T> dictionary)
        {
            object value = property.GetValue(source);
            if (IsOfType<T>(value))
                dictionary.Add(property.Name, (T)value);
        }

        private static bool IsOfType<T>(object value)
        {
            return value is T;
        }
    }
}