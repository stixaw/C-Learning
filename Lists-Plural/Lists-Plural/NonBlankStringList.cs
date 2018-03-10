using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_Plural
{
	public class NonBlankStringList : Collection<string>  // requires Collections.ObjectModel
	{
		// allows for override methods which customize the List<T> Add which allows you to add anything no matter what.
		// through the encapsulation of Collection<t> of List<t>
		protected override void InsertItem(int index, string item)
		{
			if (string.IsNullOrWhiteSpace(item))
			{
				throw new ArgumentException("Element is null or whitespace");
			};
			base.InsertItem(index, item);
		}

		protected override void SetItem(int index, string item)
		{
			if (string.IsNullOrWhiteSpace(item))
			{
				throw new ArgumentException("Element is null or whitespace");
			};
			base.SetItem(index, item);
		}
	}
}
