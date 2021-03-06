// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Graph.Rbac.Models
{
    public partial class ApplicationCreateParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("displayName");
            writer.WriteStringValue(DisplayName);
            if (IdentifierUris != null)
            {
                writer.WritePropertyName("identifierUris");
                writer.WriteStartArray();
                foreach (var item in IdentifierUris)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (AllowGuestsSignIn != null)
            {
                writer.WritePropertyName("allowGuestsSignIn");
                writer.WriteBooleanValue(AllowGuestsSignIn.Value);
            }
            if (AllowPassthroughUsers != null)
            {
                writer.WritePropertyName("allowPassthroughUsers");
                writer.WriteBooleanValue(AllowPassthroughUsers.Value);
            }
            if (AppLogoUrl != null)
            {
                writer.WritePropertyName("appLogoUrl");
                writer.WriteStringValue(AppLogoUrl);
            }
            if (AppRoles != null)
            {
                writer.WritePropertyName("appRoles");
                writer.WriteStartArray();
                foreach (var item in AppRoles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (AppPermissions != null)
            {
                writer.WritePropertyName("appPermissions");
                writer.WriteStartArray();
                foreach (var item in AppPermissions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (AvailableToOtherTenants != null)
            {
                writer.WritePropertyName("availableToOtherTenants");
                writer.WriteBooleanValue(AvailableToOtherTenants.Value);
            }
            if (ErrorUrl != null)
            {
                writer.WritePropertyName("errorUrl");
                writer.WriteStringValue(ErrorUrl);
            }
            if (GroupMembershipClaims != null)
            {
                writer.WritePropertyName("groupMembershipClaims");
                writer.WriteStringValue(GroupMembershipClaims.Value.ToString());
            }
            if (Homepage != null)
            {
                writer.WritePropertyName("homepage");
                writer.WriteStringValue(Homepage);
            }
            if (InformationalUrls != null)
            {
                writer.WritePropertyName("informationalUrls");
                writer.WriteObjectValue(InformationalUrls);
            }
            if (IsDeviceOnlyAuthSupported != null)
            {
                writer.WritePropertyName("isDeviceOnlyAuthSupported");
                writer.WriteBooleanValue(IsDeviceOnlyAuthSupported.Value);
            }
            if (KeyCredentials != null)
            {
                writer.WritePropertyName("keyCredentials");
                writer.WriteStartArray();
                foreach (var item in KeyCredentials)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (KnownClientApplications != null)
            {
                writer.WritePropertyName("knownClientApplications");
                writer.WriteStartArray();
                foreach (var item in KnownClientApplications)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (LogoutUrl != null)
            {
                writer.WritePropertyName("logoutUrl");
                writer.WriteStringValue(LogoutUrl);
            }
            if (Oauth2AllowImplicitFlow != null)
            {
                writer.WritePropertyName("oauth2AllowImplicitFlow");
                writer.WriteBooleanValue(Oauth2AllowImplicitFlow.Value);
            }
            if (Oauth2AllowUrlPathMatching != null)
            {
                writer.WritePropertyName("oauth2AllowUrlPathMatching");
                writer.WriteBooleanValue(Oauth2AllowUrlPathMatching.Value);
            }
            if (Oauth2Permissions != null)
            {
                writer.WritePropertyName("oauth2Permissions");
                writer.WriteStartArray();
                foreach (var item in Oauth2Permissions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Oauth2RequirePostResponse != null)
            {
                writer.WritePropertyName("oauth2RequirePostResponse");
                writer.WriteBooleanValue(Oauth2RequirePostResponse.Value);
            }
            if (OrgRestrictions != null)
            {
                writer.WritePropertyName("orgRestrictions");
                writer.WriteStartArray();
                foreach (var item in OrgRestrictions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (OptionalClaims != null)
            {
                writer.WritePropertyName("optionalClaims");
                writer.WriteObjectValue(OptionalClaims);
            }
            if (PasswordCredentials != null)
            {
                writer.WritePropertyName("passwordCredentials");
                writer.WriteStartArray();
                foreach (var item in PasswordCredentials)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (PreAuthorizedApplications != null)
            {
                writer.WritePropertyName("preAuthorizedApplications");
                writer.WriteStartArray();
                foreach (var item in PreAuthorizedApplications)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (PublicClient != null)
            {
                writer.WritePropertyName("publicClient");
                writer.WriteBooleanValue(PublicClient.Value);
            }
            if (PublisherDomain != null)
            {
                writer.WritePropertyName("publisherDomain");
                writer.WriteStringValue(PublisherDomain);
            }
            if (ReplyUrls != null)
            {
                writer.WritePropertyName("replyUrls");
                writer.WriteStartArray();
                foreach (var item in ReplyUrls)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (RequiredResourceAccess != null)
            {
                writer.WritePropertyName("requiredResourceAccess");
                writer.WriteStartArray();
                foreach (var item in RequiredResourceAccess)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (SamlMetadataUrl != null)
            {
                writer.WritePropertyName("samlMetadataUrl");
                writer.WriteStringValue(SamlMetadataUrl);
            }
            if (SignInAudience != null)
            {
                writer.WritePropertyName("signInAudience");
                writer.WriteStringValue(SignInAudience);
            }
            if (WwwHomepage != null)
            {
                writer.WritePropertyName("wwwHomepage");
                writer.WriteStringValue(WwwHomepage);
            }
            writer.WriteEndObject();
        }
    }
}
