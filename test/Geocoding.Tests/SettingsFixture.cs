using Microsoft.Extensions.Configuration;
using Xunit;

namespace Geocoding.Tests
{
    public class SettingsFixture
    {
        readonly IConfigurationRoot config;

        public SettingsFixture()
        {
            config = new ConfigurationBuilder()
                .AddJsonFile("settings.json")
                .AddJsonFile("settings-override.json", optional: true)
                .Build();
        }

        public string YahooConsumerKey
        {
            get { return config["yahooConsumerKey"]; } // Change GetValue to indexer
        }

        public string YahooConsumerSecret
        {
            get { return config["yahooConsumerSecret"]; } // Change GetValue to indexer
        }

        public string BingMapsKey
        {
            get { return config["bingMapsKey"]; } // Change GetValue to indexer
        }

        public string GoogleApiKey
        {
            get { return config["googleApiKey"]; } // Change GetValue to indexer
        }

        public string MapQuestKey
        {
            get { return config["mapQuestKey"]; } // Change GetValue to indexer
        }

        public string HereAppId
        {
            get { return config["hereAppId"]; } // Change GetValue to indexer
        }

        public string HereAppCode
        {
            get { return config["hereAppCode"]; } // Change GetValue to indexer
        }
    }

	[CollectionDefinition("Settings")]
	public class SettingsCollection : ICollectionFixture<SettingsFixture>
	{
		// https://xunit.github.io/docs/shared-context.html
		// This class has no code, and is never created. Its purpose is simply
		// to be the place to apply [CollectionDefinition] and all the
		// ICollectionFixture<> interfaces.
	}
}
