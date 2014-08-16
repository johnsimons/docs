﻿using Raven.Client.Document;
using Raven.Documentation.CodeSamples.Orders;
using Raven.Json.Linq;

namespace Raven.Documentation.CodeSamples.ClientApi.Session.HowTo
{
	public class GetMetadata
	{
		private interface IFoo
		{
			#region get_metadata_1
			RavenJObject GetMetadataFor<T>(T instance);
			#endregion
		}

		public GetMetadata()
		{
			using (var store = new DocumentStore())
			{
				using (var session = store.OpenSession())
				{
					#region get_metadata_2
					var employee = session.Load<Employee>("employees/1");
					var metadata = session.Advanced.GetMetadataFor(employee);
					#endregion
				}
			}
		}
	}
}