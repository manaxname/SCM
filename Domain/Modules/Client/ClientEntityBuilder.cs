using System;
using DataModel;
using Domain.Modules.Phones;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Domain.Modules.Client
{
	internal class ClientEntityBuilder
	{
		private static readonly PhoneNumberBuilder PhoneNumberBuilder = new PhoneNumberBuilder();

		public ClientEntity BuildClient(User origin)
		{
			var entity = new ClientEntity(origin.Id)
			{
				Email = new Email(origin.Email),
				BirthDay = origin.Birthday,
				Name = origin.Name,
				Patronymic = origin.Patronymic,
				Surname = origin.Surname,
				PhoneNumber = PhoneNumberBuilder.BuildPhoneNumber(origin.Phone, CountryPhoneCodeEnum.Belarus)
			};
			BuildAddress(entity, origin.UserAddresses);
			return entity;
		}

		public void SetNewEmail(ClientEntity entity, string origin)
		{
			entity.Email = new Email(origin);
		}

		public void SetNewBirthDay(ClientEntity entity, DateTime? origin)
		{
			entity.BirthDay = origin;
		}

		public void SetNewName(ClientEntity entity, string origin)
		{
			entity.Name = origin;
		}

		public void SetNewPatronymic(ClientEntity entity, string origin)
		{
			entity.Patronymic = origin;
		}

		public void SetNewSurname(ClientEntity entity, string origin)
		{
			entity.Surname = origin;
		}

		public void SetNewPhoneNumber(ClientEntity entity, string origin)
		{
			entity.PhoneNumber = PhoneNumberBuilder.BuildPhoneNumber(origin, CountryPhoneCodeEnum.Belarus);
		}

		public static void AddNewAddress(ClientEntity entity, Address address)
		{
			IList<Address> addresses = new List<Address>(entity.Addresses.Count + 1);
			foreach (Address entityAddress in entity.Addresses)
			{
				addresses.Add(entityAddress);
			}

			addresses.Add(address);
			entity.Addresses = new ReadOnlyCollection<Address>(addresses);
		}

		private static void BuildAddress(ClientEntity entity, IEnumerable<UserAddress> addresses)
		{
			if (addresses == null)
				return;

			IList<Address> list = new List<Address>();

			foreach (UserAddress address in addresses)
			{
				list.Add(new Address(address));
			}

			entity.Addresses = new ReadOnlyCollection<Address>(list);
		}
	}
}