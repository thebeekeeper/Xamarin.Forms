using System;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Xamarin.Forms.Pages.Azure
{
	public abstract class AzureSource : Element
	{
		public static AzureSource FromString(string json)
		{
			return null;
			//return new StringJsonSource { Json = json };
		}

		public static AzureSource FromUri(Uri uri)
		{
			return null;
			//return new UriJsonSource { Uri = uri };
		}

		public static readonly BindableProperty UriProperty = 
			BindableProperty.Create(nameof(Uri), typeof(Uri), typeof(AzureSource), null);

		public Uri Uri
		{
			get { return (Uri)GetValue(UriProperty); }
			set { SetValue(UriProperty, value); }
		}

		public abstract Task<JToken> GetJson();

		public static implicit operator AzureSource(string json)
		{
			return FromString(json);
		}
	}
}