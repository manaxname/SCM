using DataModel;
using Domain.Modules.Phones;

namespace Domain.Modules.Client
{
	internal class ClientEntityBuilder
	{
		private static readonly PhoneNumberBuilder PhoneNumberBuilder = new PhoneNumberBuilder();

		internal ClientEntity BuildClient(User origin)
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
			return entity;
		}
	}
}