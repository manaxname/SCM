using System;
using System.Collections.ObjectModel;
using Domain.General;
using Domain.Modules.Phones;

namespace Domain.Modules.Client
{
	public sealed class ClientEntity : Entity
	{
		internal ClientEntity(int id) : base(id)
		{
		}

		public Email Email { get; internal set; }
		public InternationalPhoneNumber PhoneNumber { get; internal set; }
		public string Name { get; internal set; }
		public string Surname { get; internal set; }
		public string Patronymic { get; internal set; }
		public DateTime? BirthDay { get; internal set; }

		public ReadOnlyCollection<Address> Addresses { get; internal set; }
	}
}