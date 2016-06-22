﻿using System;
using System.Collections.Generic;

namespace HalClient.Net.PCL.Parser
{
	internal class EmbeddedResourceObject : ResourceObjectBase, IEmbeddedResourceObject
	{
		public EmbeddedResourceObject(IEnumerable<ILinkObject> links, IEnumerable<IEmbeddedResourceObject> embedded,
			IEnumerable<IStateValue> state, string rel)
			: base(state, embedded, links)
		{
			if (string.IsNullOrEmpty(rel))
				throw new ArgumentNullException(nameof(rel));

			Rel = rel;
		}

		public string Rel { get; set; }
	}
}