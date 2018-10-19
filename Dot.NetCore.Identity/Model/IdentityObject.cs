using System;

namespace Dot.NetCore.Identity.Model
{
	public abstract class IdentityObject
	{
		public string Id { get; set; } = Guid.NewGuid().ToString();
	}
}