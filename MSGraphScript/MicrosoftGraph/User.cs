// ------------------------------------------------------------------------------
//  Derived from msgraph-sdk-dotnet.
//  msgraph-sdk-dotnet is Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// The type User.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public partial class User : DirectoryObject
    {
    
		///<summary>
		/// The User constructor
		///</summary>
        public User()
        {
            this.ODataType = "microsoft.graph.user";
        }

        /// <summary>
        /// Gets or sets account enabled.
        /// true if the account is enabled; otherwise, false. This property is required when a user is created. Supports $filter.
        /// </summary>
        public bool? AccountEnabled;

        /// <summary>
        /// Gets or sets age group.
        /// Sets the age group of the user. Allowed values: null, minor, notAdult and adult. Refer to the legal age group property definitions for further information.
        /// </summary>
        public string AgeGroup;

        /// <summary>
        /// Gets or sets assigned licenses.
        /// The licenses that are assigned to the user. Not nullable.
        /// </summary>
       // public IEnumerable<AssignedLicense> AssignedLicenses;
    
        /// <summary>
        /// Gets or sets assigned plans.
        /// The plans that are assigned to the user. Read-only. Not nullable.
        /// </summary>
        //public IEnumerable<AssignedPlan> AssignedPlans { get; set; }

        /// <summary>
        /// Gets or sets business phones.
        /// The telephone numbers for the user. NOTE: Although this is a string collection, only one number can be set for this property.
        /// </summary>
        public IEnumerable<string> BusinessPhones;

        /// <summary>
        /// Gets or sets city.
        /// The city in which the user is located. Supports $filter.
        /// </summary>
        public string City;

        /// <summary>
        /// Gets or sets company name.
        /// The company name which the user is associated. This property can be useful for describing the company that an external user comes from. The maximum length of the company name is 64 chararcters.Returned only on $select.
        /// </summary>
        public string CompanyName;

        /// <summary>
        /// Gets or sets consent provided for minor.
        /// Sets whether consent has been obtained for minors. Allowed values: null, granted, denied and notRequired. Refer to the legal age group property definitions for further information.
        /// </summary>
        public string ConsentProvidedForMinor;

        /// <summary>
        /// Gets or sets country.
        /// The country/region in which the user is located; for example, 'US' or 'UK'. Supports $filter.
        /// </summary>
        public string Country;

        /// <summary>
        /// Gets or sets created date time.
        /// The created date of the user object.
        /// </summary>
        public Date CreatedDateTime;

        /// <summary>
        /// Gets or sets creation type.
        /// Indicates whether the user account was created as a regular school or work account (null), an external account (Invitation), a local account for an Azure Active Directory B2C tenant (LocalAccount) or self-service sign-up using email verification (EmailVerified). Read-only.
        /// </summary>
        public string CreationType;

        /// <summary>
        /// Gets or sets department.
        /// The name for the department in which the user works. Supports $filter.
        /// </summary>
        public string Department;

        /// <summary>
        /// Gets or sets display name.
        /// The name displayed in the address book for the user. This is usually the combination of the user's first name, middle initial and last name. This property is required when a user is created and it cannot be cleared during updates. Supports $filter and $orderby.
        /// </summary>
        public string DisplayName;

        /// <summary>
        /// Gets or sets employee id.
        /// The employee identifier assigned to the user by the organization. Supports $filter.
        /// </summary>
        public string EmployeeId;

        /// <summary>
        /// Gets or sets external user state.
        /// For an external user invited to the tenant using the invitation API, this property represents the invited user's invitation status. For invited users, the state can be PendingAcceptance or Accepted, or null for all other users. Returned only on $select. Supports $filter with the supported values. For example: $filter=externalUserState eq 'PendingAcceptance'.
        /// </summary>
        public string ExternalUserState;

        /// <summary>
        /// Gets or sets external user state change date time.
        /// Shows the timestamp for the latest change to the externalUserState property. Returned only on $select.
        /// </summary>
        public Date ExternalUserStateChangeDateTime;

        /// <summary>
        /// Gets or sets fax number.
        /// The fax number of the user.
        /// </summary>
        public string FaxNumber;

        /// <summary>
        /// Gets or sets given name.
        /// The given name (first name) of the user. Supports $filter.
        /// </summary>
        public string GivenName;

        /// <summary>
        /// Gets or sets identities.
        /// Represents the identities that can be used to sign in to this user account. An identity can be provided by Microsoft (also known as a local account), by organizations, or by social identity providers such as Facebook, Google, and Microsoft, and tied to a user account. May contain multiple items with the same signInType value. Supports $filter.
        /// </summary>
        // public IEnumerable<ObjectIdentity> Identities;

        /// <summary>
        /// Gets or sets im addresses.
        /// The instant message voice over IP (VOIP) session initiation protocol (SIP) addresses for the user. Read-only.
        /// </summary>
        public IEnumerable<string> ImAddresses;

        /// <summary>
        /// Gets or sets is resource account.
        /// Do not use – reserved for future use.
        /// </summary>
        public bool? IsResourceAccount;

        /// <summary>
        /// Gets or sets job title.
        /// The user’s job title. Supports $filter.
        /// </summary>
        public string JobTitle;

        /// <summary>
        /// Gets or sets last password change date time.
        /// The time when this Azure AD user last changed their password. The date and time information uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        /// </summary>
        public Date LastPasswordChangeDateTime;

        /// <summary>
        /// Gets or sets legal age group classification.
        /// Used by enterprise applications to determine the legal age group of the user. This property is read-only and calculated based on ageGroup and consentProvidedForMinor properties. Allowed values: null, minorWithOutParentalConsent, minorWithParentalConsent, minorNoParentalConsentRequired, notAdult and adult. Refer to the legal age group property definitions for further information.)
        /// </summary>
        public string LegalAgeGroupClassification;

        /// <summary>
        /// Gets or sets license assignment states.
        /// State of license assignments for this user. Read-only.
        /// </summary>
        // public IEnumerable<LicenseAssignmentState> LicenseAssignmentStates;

        /// <summary>
        /// Gets or sets mail.
        /// The SMTP address for the user, for example, 'jeff@contoso.onmicrosoft.com'. Supports $filter.
        /// </summary>
        public string Mail;

        /// <summary>
        /// Gets or sets mail nickname.
        /// The mail alias for the user. This property must be specified when a user is created. Supports $filter.
        /// </summary>
        public string MailNickname;

        /// <summary>
        /// Gets or sets mobile phone.
        /// The primary cellular telephone number for the user.
        /// </summary>
        public string MobilePhone;

        /// <summary>
        /// Gets or sets office location.
        /// The office location in the user's place of business.
        /// </summary>
        public string OfficeLocation;

        /// <summary>
        /// Gets or sets on premises distinguished name.
        /// Contains the on-premises Active Directory distinguished name or DN. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect. Read-only.
        /// </summary>
        public string OnPremisesDistinguishedName;

        /// <summary>
        /// Gets or sets on premises domain name.
        /// Contains the on-premises domainFQDN, also called dnsDomainName synchronized from the on-premises directory. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect. Read-only.
        /// </summary>
        public string OnPremisesDomainName;

        /// <summary>
        /// Gets or sets on premises extension attributes.
        /// Contains extensionAttributes 1-15 for the user. Note that the individual extension attributes are neither selectable nor filterable. For an onPremisesSyncEnabled user, the source of authority for this set of properties is the on-premises and is read-only. For a cloud-only user (where onPremisesSyncEnabled is false), these properties may be set during creation or update. These extension attributes are also known as Exchange custom attributes 1-15.
        /// </summary>
        // public OnPremisesExtensionAttributes OnPremisesExtensionAttributes;

        /// <summary>
        /// Gets or sets on premises immutable id.
        /// This property is used to associate an on-premises Active Directory user account to their Azure AD user object. This property must be specified when creating a new user account in the Graph if you are using a federated domain for the user’s userPrincipalName (UPN) property. Important: The $ and _ characters cannot be used when specifying this property. Supports $filter.
        /// </summary>
        public string OnPremisesImmutableId;

        /// <summary>
        /// Gets or sets on premises last sync date time.
        /// Indicates the last time at which the object was synced with the on-premises directory; for example: '2013-02-16T03:04:54Z'. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
        /// </summary>
        public Date OnPremisesLastSyncDateTime;

        /// <summary>
        /// Gets or sets on premises provisioning errors.
        /// Errors when using Microsoft synchronization product during provisioning.
        /// </summary>
        // public IEnumerable<OnPremisesProvisioningError> OnPremisesProvisioningErrors { get; set; }

        /// <summary>
        /// Gets or sets on premises sam account name.
        /// Contains the on-premises samAccountName synchronized from the on-premises directory. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect. Read-only.
        /// </summary>
        public string OnPremisesSamAccountName;

        /// <summary>
        /// Gets or sets on premises security identifier.
        /// Contains the on-premises security identifier (SID) for the user that was synchronized from on-premises to the cloud. Read-only.
        /// </summary>
        public string OnPremisesSecurityIdentifier;

        /// <summary>
        /// Gets or sets on premises sync enabled.
        /// true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced; null if this object has never been synced from an on-premises directory (default). Read-only
        /// </summary>
        public bool? OnPremisesSyncEnabled;

        /// <summary>
        /// Gets or sets on premises user principal name.
        /// Contains the on-premises userPrincipalName synchronized from the on-premises directory. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect. Read-only.
        /// </summary>
        public string OnPremisesUserPrincipalName;

        /// <summary>
        /// Gets or sets other mails.
        /// A list of additional email addresses for the user; for example: ['bob@contoso.com', 'Robert@fabrikam.com']. Supports $filter.
        /// </summary>
        public IEnumerable<string> OtherMails;

        /// <summary>
        /// Gets or sets password policies.
        /// Specifies password policies for the user. This value is an enumeration with one possible value being 'DisableStrongPassword', which allows weaker passwords than the default policy to be specified. 'DisablePasswordExpiration' can also be specified. The two may be specified together; for example: 'DisablePasswordExpiration, DisableStrongPassword'.
        /// </summary>
        public string PasswordPolicies;

        /// <summary>
        /// Gets or sets password profile.
        /// Specifies the password profile for the user. The profile contains the user’s password. This property is required when a user is created. The password in the profile must satisfy minimum requirements as specified by the passwordPolicies property. By default, a strong password is required.
        /// </summary>
        // public PasswordProfile PasswordProfile;

        /// <summary>
        /// Gets or sets postal code.
        /// The postal code for the user's postal address. The postal code is specific to the user's country/region. In the United States of America, this attribute contains the ZIP code.
        /// </summary>
        public string PostalCode;

        /// <summary>
        /// Gets or sets preferred language.
        /// The preferred language for the user. Should follow ISO 639-1 Code; for example 'en-US'.
        /// </summary>
        public string PreferredLanguage;

        /// <summary>
        /// Gets or sets provisioned plans.
        /// The plans that are provisioned for the user. Read-only. Not nullable.
        /// </summary>
        // public IEnumerable<ProvisionedPlan> ProvisionedPlans;

        /// <summary>
        /// Gets or sets proxy addresses.
        /// For example: ['SMTP: bob@contoso.com', 'smtp: bob@sales.contoso.com'] The any operator is required for filter expressions on multi-valued properties. Read-only, Not nullable. Supports $filter.
        /// </summary>
        public IEnumerable<string> ProxyAddresses;

        /// <summary>
        /// Gets or sets show in address list.
        /// true if the Outlook global address list should contain this user, otherwise false. If not set, this will be treated as true. For users invited through the invitation manager, this property will be set to false.
        /// </summary>
        public bool? ShowInAddressList;

        /// <summary>
        /// Gets or sets sign in sessions valid from date time.
        /// Any refresh tokens or sessions tokens (session cookies) issued before this time are invalid, and applications will get an error when using an invalid refresh or sessions token to acquire a delegated access token (to access APIs such as Microsoft Graph).  If this happens, the application will need to acquire a new refresh token by making a request to the authorize endpoint. Read-only. Use revokeSignInSessions to reset.
        /// </summary>
        public Date SignInSessionsValidFromDateTime;

        /// <summary>
        /// Gets or sets state.
        /// The state or province in the user's address. Supports $filter.
        /// </summary>
        public string State;

        /// <summary>
        /// Gets or sets street address.
        /// The street address of the user's place of business.
        /// </summary>
        public string StreetAddress;

        /// <summary>
        /// Gets or sets surname.
        /// The user's surname (family name or last name). Supports $filter.
        /// </summary>
        public string Surname;

        /// <summary>
        /// Gets or sets usage location.
        /// A two letter country code (ISO standard 3166). Required for users that will be assigned licenses due to legal requirement to check for availability of services in countries.  Examples include: 'US', 'JP', and 'GB'. Not nullable. Supports $filter.
        /// </summary>
        public string UsageLocation;

        /// <summary>
        /// Gets or sets user principal name.
        /// The user principal name (UPN) of the user. The UPN is an Internet-style login name for the user based on the Internet standard RFC 822. By convention, this should map to the user's email name. The general format is alias@domain, where domain must be present in the tenant’s collection of verified domains. This property is required when a user is created. The verified domains for the tenant can be accessed from the verifiedDomains property of organization. Supports $filter and $orderby.
        /// </summary>
        public string UserPrincipalName;

        /// <summary>
        /// Gets or sets user type.
        /// A string value that can be used to classify user types in your directory, such as 'Member' and 'Guest'. Supports $filter.
        /// </summary>
        public string UserType;

        /// <summary>
        /// Gets or sets mailbox settings.
        /// Settings for the primary mailbox of the signed-in user. You can get or update settings for sending automatic replies to incoming messages, locale and time zone.
        /// </summary>
        //public MailboxSettings MailboxSettings;

        /// <summary>
        /// Gets or sets device enrollment limit.
        /// The limit on the maximum number of devices that the user is permitted to enroll. Allowed values are 5 or 1000.
        /// </summary>
        public int? DeviceEnrollmentLimit;

        /// <summary>
        /// Gets or sets about me.
        /// A freeform text entry field for the user to describe themselves.
        /// </summary>
        public string AboutMe;

        /// <summary>
        /// Gets or sets birthday.
        /// The birthday of the user. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        /// </summary>
        public Date Birthday;

        /// <summary>
        /// Gets or sets hire date.
        /// The hire date of the user. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        /// </summary>
        public Date HireDate;

        /// <summary>
        /// Gets or sets interests.
        /// A list for the user to describe their interests.
        /// </summary>
        public IEnumerable<string> Interests;

        /// <summary>
        /// Gets or sets my site.
        /// The URL for the user's personal site.
        /// </summary>
        public string MySite;

        /// <summary>
        /// Gets or sets past projects.
        /// A list for the user to enumerate their past projects.
        /// </summary>
        public IEnumerable<string> PastProjects;

        /// <summary>
        /// Gets or sets preferred name.
        /// The preferred name for the user.
        /// </summary>
        public string PreferredName;

        /// <summary>
        /// Gets or sets responsibilities.
        /// A list for the user to enumerate their responsibilities.
        /// </summary>
        public IEnumerable<string> Responsibilities;

        /// <summary>
        /// Gets or sets schools.
        /// A list for the user to enumerate the schools they have attended.
        /// </summary>
        public IEnumerable<string> Schools;

        /// <summary>
        /// Gets or sets skills.
        /// A list for the user to enumerate their skills.
        /// </summary>
        public IEnumerable<string> Skills;

        /// <summary>
        /// Gets or sets app role assignments.
        /// </summary>
        // public IUserAppRoleAssignmentsCollectionPage AppRoleAssignments;

        /// <summary>
        /// Gets or sets created objects.
        /// Directory objects that were created by the user. Read-only. Nullable.
        /// </summary>
        // public IUserCreatedObjectsCollectionWithReferencesPage CreatedObjects;

        /// <summary>
        /// Gets or sets direct reports.
        /// The users and contacts that report to the user. (The users and contacts that have their manager property set to this user.) Read-only. Nullable.
        /// </summary>

        // public IUserDirectReportsCollectionWithReferencesPage DirectReports { get; set; }

        /// <summary>
        /// Gets or sets license details.
        /// A collection of this user's license details. Read-only.
        /// </summary>
        // public IUserLicenseDetailsCollectionPage LicenseDetails { get; set; }

        /// <summary>
        /// Gets or sets manager.
        /// The user or contact that is this user’s manager. Read-only. (HTTP Methods: GET, PUT, DELETE.)
        /// </summary>
        public DirectoryObject Manager;

        /// <summary>
        /// Gets or sets member of.
        /// The groups and directory roles that the user is a member of. Read-only. Nullable.
        /// </summary>
        //public IUserMemberOfCollectionWithReferencesPage MemberOf;
    
        /// <summary>
        /// Gets or sets oauth2permission grants.
        /// </summary>
        // public IUserOauth2PermissionGrantsCollectionWithReferencesPage Oauth2PermissionGrants { get; set; }
    
        /// <summary>
        /// Gets or sets owned devices.
        /// Devices that are owned by the user. Read-only. Nullable.
        /// </summary>
        // public IUserOwnedDevicesCollectionWithReferencesPage OwnedDevices { get; set; }
    
        /// <summary>
        /// Gets or sets owned objects.
        /// Directory objects that are owned by the user. Read-only. Nullable.
        /// </summary>
        // public IUserOwnedObjectsCollectionWithReferencesPage OwnedObjects { get; set; }
    
        /// <summary>
        /// Gets or sets registered devices.
        /// Devices that are registered for the user. Read-only. Nullable.
        /// </summary>
        // public IUserRegisteredDevicesCollectionWithReferencesPage RegisteredDevices { get; set; }
    
        /// <summary>
        /// Gets or sets scoped role member of.
        /// </summary>
        // public IUserScopedRoleMemberOfCollectionPage ScopedRoleMemberOf { get; set; }
    
        /// <summary>
        /// Gets or sets transitive member of.
        /// </summary>
        // public IUserTransitiveMemberOfCollectionWithReferencesPage TransitiveMemberOf { get; set; }
    
        /// <summary>
        /// Gets or sets calendar.
        /// The user's primary calendar. Read-only.
        /// </summary>
        // public Calendar Calendar { get; set; }
    
        /// <summary>
        /// Gets or sets calendar groups.
        /// The user's calendar groups. Read-only. Nullable.
        /// </summary>
        //        public IUserCalendarGroupsCollectionPage CalendarGroups { get; set; }
    
        /// <summary>
        /// Gets or sets calendars.
        /// The user's calendars. Read-only. Nullable.
        /// </summary>
        // public IUserCalendarsCollectionPage Calendars { get; set; }
    
        /// <summary>
        /// Gets or sets calendar view.
        /// The calendar view for the calendar. Read-only. Nullable.
        /// </summary>
        // public IUserCalendarViewCollectionPage CalendarView { get; set; }
    
        /// <summary>
        /// Gets or sets contact folders.
        /// The user's contacts folders. Read-only. Nullable.
        /// </summary>
        // public IUserContactFoldersCollectionPage ContactFolders { get; set; }
    
        /// <summary>
        /// Gets or sets contacts.
        /// The user's contacts. Read-only. Nullable.
        /// </summary>
        // public IUserContactsCollectionPage Contacts { get; set; }
    
        /// <summary>
        /// Gets or sets events.
        /// The user's events. Default is to show Events under the Default Calendar. Read-only. Nullable.
        /// </summary>
        // public IUserEventsCollectionPage Events { get; set; }
    
        /// <summary>
        /// Gets or sets inference classification.
        /// Relevance classification of the user's messages based on explicit designations which override inferred relevance or importance.
        /// </summary>
        // public InferenceClassification InferenceClassification { get; set; }
    
        /// <summary>
        /// Gets or sets mail folders.
        /// The user's mail folders. Read-only. Nullable.
        /// </summary>
        // public IUserMailFoldersCollectionPage MailFolders { get; set; }
    
        /// <summary>
        /// Gets or sets messages.
        /// The messages in a mailbox or folder. Read-only. Nullable.
        /// </summary>
        // public IUserMessagesCollectionPage Messages { get; set; }
    
        /// <summary>
        /// Gets or sets outlook.
        /// Read-only.
        /// </summary>
        // public OutlookUser Outlook { get; set; }
    
        /// <summary>
        /// Gets or sets people.
        /// People that are relevant to the user. Read-only. Nullable.
        /// </summary>
        // public IUserPeopleCollectionPage People { get; set; }
    
        /// <summary>
        /// Gets or sets photo.
        /// The user's profile photo. Read-only.
        /// </summary>
        // public ProfilePhoto Photo { get; set; }
    
        /// <summary>
        /// Gets or sets photos.
        /// </summary>
        // public IUserPhotosCollectionPage Photos { get; set; }
    
        /// <summary>
        /// Gets or sets drive.
        /// The user's OneDrive. Read-only.
        /// </summary>
        // public Drive Drive { get; set; }
    
        /// <summary>
        /// Gets or sets drives.
        /// A collection of drives available for this user. Read-only.
        /// </summary>

        // public IUserDrivesCollectionPage Drives { get; set; }
    
        /// <summary>
        /// Gets or sets followed sites.
        /// </summary>
        //public IUserFollowedSitesCollectionWithReferencesPage FollowedSites { get; set; }
    
        /// <summary>
        /// Gets or sets extensions.
        /// The collection of open extensions defined for the user. Read-only. Nullable.
        /// </summary>
        // public IUserExtensionsCollectionPage Extensions { get; set; }
    
        /// <summary>
        /// Gets or sets managed devices.
        /// The managed devices associated with the user.
        /// </summary>
        // public IUserManagedDevicesCollectionPage ManagedDevices { get; set; }
    
        /// <summary>
        /// Gets or sets managed app registrations.
        /// Zero or more managed app registrations that belong to the user.
        /// </summary>
        // public IUserManagedAppRegistrationsCollectionWithReferencesPage ManagedAppRegistrations { get; set; }
    
        /// <summary>
        /// Gets or sets device management troubleshooting events.
        /// The list of troubleshooting events for this user.
        /// </summary>
        // public IUserDeviceManagementTroubleshootingEventsCollectionPage DeviceManagementTroubleshootingEvents { get; set; }
    
        /// <summary>
        /// Gets or sets planner.
        /// Entry-point to the Planner resource that might exist for a user. Read-only.
        /// </summary>
        // public PlannerUser Planner { get; set; }
    
        /// <summary>
        /// Gets or sets insights.
        /// Read-only. Nullable.
        /// </summary>
        // public OfficeGraphInsights Insights { get; set; }
    
        /// <summary>
        /// Gets or sets settings.
        /// </summary>
        // public UserSettings Settings { get; set; }
    
        /// <summary>
        /// Gets or sets onenote.
        /// Read-only.
        /// </summary>
        // public Onenote Onenote { get; set; }
    
        /// <summary>
        /// Gets or sets activities.
        /// The user's activities across devices. Read-only. Nullable.
        /// </summary>
        // public IUserActivitiesCollectionPage Activities { get; set; }
    
        /// <summary>
        /// Gets or sets online meetings.
        /// </summary>
        // public IUserOnlineMeetingsCollectionPage OnlineMeetings { get; set; }
    
        /// <summary>
        /// Gets or sets joined teams.
        /// </summary>
        // public IUserJoinedTeamsCollectionPage JoinedTeams { get; set; }    
    }
}

