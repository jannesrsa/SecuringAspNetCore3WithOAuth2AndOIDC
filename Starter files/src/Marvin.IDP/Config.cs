// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System.Collections.Generic;
using IdentityServer4;
using IdentityServer4.Models;

namespace Marvin.IDP
{
    public static class Config
    {
        public static IEnumerable<ApiResource> Apis =>
            new ApiResource[]
            {
                new ApiResource(
                    "imagegalleryapi",
                    "Image Gallery API",
                    new []{ "role" }
                    )
            };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client
                {
                    ClientName = "Image Gallery",
                    ClientId="imagegalleryclient",
                    AllowedGrantTypes = GrantTypes.Code,
                    RequirePkce = true,
                    RedirectUris= new []
                    {
                        "https://localhost:44389/signin-oidc"
                    },
                    PostLogoutRedirectUris= new []
                    {
                        "https://localhost:44389/signout-callback-oidc"
                    },
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Address,
                        "roles",
                        "imagegalleryapi",
                        "subscriptionlevel",
                        "country"
                    },
                    ClientSecrets=
                    {
                        new Secret("secret".Sha256())
                    }
                }
            };

        public static IEnumerable<IdentityResource> Ids => new IdentityResource[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Address(),

                new IdentityResource(
                    "roles",
                    "Your Role(s)",
                    new []{ "role" }),

                new IdentityResource(
                    "country",
                    "The country you're living in",
                    new List<string>() { "country" }),

                new IdentityResource(
                    "subscriptionlevel",
                    "Your subscription level",
                    new List<string>() { "subscriptionlevel" })
            };
    }
}