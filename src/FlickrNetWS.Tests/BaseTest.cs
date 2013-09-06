﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlickrNet;
using NUnit.Framework;

namespace FlickrNetWS.Tests
{
    public abstract class BaseTest
    {
        protected Flickr Instance;
        protected Flickr AuthInstance;

        protected readonly TestData Data = new TestData();

        [SetUp]
        public void CreateFlickrInstance()
        {
            Instance = new Flickr(Data.ApiKey, Data.SharedSecret);
            AuthInstance = new Flickr(Data.ApiKey, Data.SharedSecret)
                               {
                                   OAuthAccessToken = Data.AccessToken,
                                   OAuthAccessTokenSecret = Data.AccessTokenSecret
                               };
        }
    }

    public class TestData
    {
        public string ApiKey = "dbc316af64fb77dae9140de64262da0a";
        public string SharedSecret = "0781969a058a2745";
        public string AccessToken = ""; //"72157629372716886-930fcc6f8419e72e";
        public string AccessTokenSecret = ""; //"7cb6784286c9f632";

        public string UserId = "41888973@N00";
    }
}