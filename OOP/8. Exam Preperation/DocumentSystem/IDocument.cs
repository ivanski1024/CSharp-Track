using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public interface IDocument
    {
        string Name { get; }
        string Content { get; }
        void LoadProperty(string key, string value);
        void SaveAllProperties(IList<KeyValuePair<String, object>> output);
        string ToString();
    }
}
