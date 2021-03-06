﻿using System.Configuration;

namespace JustGiving.Api.Sdk.Test.Integration.Configuration
{
    public class TestConfigurations : ConfigurationSection, ITestConfigurations
    {
        [ConfigurationProperty("charityUserUserName", IsRequired = false)]
        public string CharityUserUserName
        {
            get { return (string)this["charityUserUserName"]; }
            set { this["charityUserUserName"] = value; }
        }

        [ConfigurationProperty("charityTestUserPassword")]
        public string CharityTestUserPassword
        {
            get { return (string) this["charityTestUserPassword"]; }
            set { this["charityTestUserPassword"] = value; }
        }

        [ConfigurationProperty("validEventId", IsRequired = false)]
        public int ValidEventId
        {
            get { return (int) this["validEventId"]; }
            set { this["validEventId"] = value; }
        }

        [ConfigurationProperty("rflUsername")]
        public string RflUsernName
        {
            get { return (string) this["rflUsername"]; }
            set { this["rflUsername"] = value; }
        }
        
        [ConfigurationProperty("rflDomain", IsRequired = false, DefaultValue = "www.local.raceforlifesponsorme.org")]
        public string RflDomain
        {
            get { return (string)this["rflDomain"]; }
            set { this["rflDomain"] = value; }
        }

        [ConfigurationProperty("rflEventReference")]
        public int RflEventReference
        {
            get { return (int)this["rflEventReference"]; }
            set { this["rflEventReference"] = value; }
        }

        [ConfigurationProperty("apiLocation")]
        public string ApiLocation
        {
            get { return (string)this["apiLocation"]; }
            set { this["apiLocation"] = value; }
        }

        [ConfigurationProperty("apiKey")]
        public string ApiKey
        {
            get { return (string) this["apiKey"]; }
            set { this["apiKey"] = value; }
        }
    }
}