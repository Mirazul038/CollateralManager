using CollateralManagementApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CollateralManagementApi.Controllers
{
	public class CollateralConverter : JsonConverter<Collateral>
	{
		public enum CollateralType
		{ 
			Land = 1,
			RealEstate = 2
		}

		public override bool CanConvert(Type typeToConvert)
		{
			return typeof(Collateral).IsAssignableFrom(typeToConvert);
		}

		public override Collateral Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException();

			if (!reader.Read() || reader.TokenType != JsonTokenType.PropertyName || reader.GetString() != "type")
				throw new JsonException();

			if (!reader.Read() || reader.TokenType != JsonTokenType.String)
				throw new JsonException();

			string type = reader.GetString();
			CollateralType collateralType;
			if (type == "Land")
				collateralType = CollateralType.Land;
			else
				collateralType = CollateralType.RealEstate;
			Collateral collateral = collateralType switch
			{
				CollateralType.Land => JsonSerializer.Deserialize<Land>(ref reader),
				CollateralType.RealEstate => JsonSerializer.Deserialize<RealEstate>(ref reader),
				_ => throw new JsonException()
			};
			return collateral;
		}

		public override void Write(Utf8JsonWriter writer, Collateral value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();

			if (value is Land land)
				JsonSerializer.Serialize(writer, land);
			else if (value is RealEstate realEstate)
				JsonSerializer.Serialize(writer, realEstate);
			else
				throw new NotSupportedException();
		}
	}
}
