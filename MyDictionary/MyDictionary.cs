using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary <TKey,TVal>
    {
		List<TKey> keys;
		List<TVal> vals;

		public MyDictionary()
		{
			keys = new List<TKey>();
			vals = new List<TVal>();
		}
		public TVal this[TKey key] 
		{
			get
			{
				int index = keys.IndexOf(key);
				TVal value = vals[index];
				return value;
			}
		}
		public TKey this[TVal val]
        {
            get
            {
				int index = vals.IndexOf(val);
				TKey value = keys[index];
				return value;
            }
        }
		public void Add(TKey key, TVal val)
		{
            foreach (var k in keys)
            {
				if (k.Equals(key))
				{
					throw new ArgumentException();
				}
			}
			keys.Add(key);
			vals.Add(val);
		}
	}
}
