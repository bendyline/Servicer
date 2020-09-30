// ------------------------------------------------------------------------------
//  Derived from msgraph-sdk-dotnet.
//  msgraph-sdk-dotnet is Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Graph
{
    /// <summary>
    /// The type Group.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public partial class Group : DirectoryObject
    {
    
		///<summary>
		/// The Group constructor
		///</summary>
        public Group()
        {
            this.ODataType = "microsoft.graph.group";
        }

        /// <summary>
        /// Gets or sets assigned labels.
        /// The list of sensitivity label pairs (label ID, label name) associated with an Microsoft 365 group. Returned only on $select. Read-only.
        /// </summary>
        public IEnumerable<AssignedLabel> AssignedLabels;
    
        /// <summary>
        /// Gets or sets assigned licenses.
        /// The licenses that are assigned to the group. Returned only on $select. Read-only.
        /// </summary>
        public IEnumerable<AssignedLicense> AssignedLicenses;
    
        /// <summary>
        /// Gets or sets classification.
        /// Describes a classification for the group (such as low, medium or high business impact). Valid values for this property are defined by creating a ClassificationList setting value, based on the template definition.Returned by default.
        /// </summary>
        public string Classification;
    
        /// <summary>
        /// Gets or sets created date time.
        /// Timestamp of when the group was created. The value cannot be modified and is automatically populated when the group is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Returned by default. Read-only.
        /// </summary>
        public Date CreatedDateTime;
    
        /// <summary>
        /// Gets or sets description.
        /// An optional description for the group. Returned by default.
        /// </summary>
        public string Description;
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name for the group. This property is required when a group is created and cannot be cleared during updates. Returned by default. Supports $filter and $orderby.
        /// </summary>
        public string DisplayName;
    
        /// <summary>
        /// Gets or sets expiration date time.
        /// Timestamp of when the group is set to expire. The value cannot be modified and is automatically populated when the group is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Returned by default. Read-only.
        /// </summary>
        public Date ExpirationDateTime;
    
        /// <summary>
        /// Gets or sets group types.
        /// Specifies the group type and its membership.  If the collection contains Unified, the group is a Microsoft 365 group; otherwise, it's either a security group or distribution group. For details, see groups overview.If the collection includes DynamicMembership, the group has dynamic membership; otherwise, membership is static.  Returned by default. Supports $filter.
        /// </summary>
        public IEnumerable<string> GroupTypes;
    
        /// <summary>
        /// Gets or sets has members with license errors.
        /// Indicates whether there are members in this group that have license errors from its group-based license assignment. This property is never returned on a GET operation. You can use it as a $filter argument to get groups that have members with license errors (that is, filter for this property being true). See an example.
        /// </summary>
        public bool? HasMembersWithLicenseErrors;
    
        /// <summary>
        /// Gets or sets license processing state.
        /// Indicates status of the group license assignment to all members of the group. Default value is false. Read-only. Possible values: QueuedForProcessing, ProcessingInProgress, and ProcessingComplete.Returned only on $select. Read-only.
        /// </summary>
        public LicenseProcessingState LicenseProcessingState;
    
        /// <summary>
        /// Gets or sets mail.
        /// The SMTP address for the group, for example, 'serviceadmins@contoso.onmicrosoft.com'. Returned by default. Read-only. Supports $filter.
        /// </summary>
        public string Mail;
    
        /// <summary>
        /// Gets or sets mail enabled.
        /// Specifies whether the group is mail-enabled. Returned by default.
        /// </summary>
        public bool? MailEnabled;
    
        /// <summary>
        /// Gets or sets mail nickname.
        /// The mail alias for the group, unique in the organization. This property must be specified when a group is created. Returned by default. Supports $filter.
        /// </summary>
        public string MailNickname;
    
        /// <summary>
        /// Gets or sets membership rule.
        /// The rule that determines members for this group if the group is a dynamic group (groupTypes contains DynamicMembership). For more information about the syntax of the membership rule, see Membership Rules syntax. Returned by default.
        /// </summary>
        public string MembershipRule;
    
        /// <summary>
        /// Gets or sets membership rule processing state.
        /// Indicates whether the dynamic membership processing is on or paused. Possible values are 'On' or 'Paused'. Returned by default.
        /// </summary>
        public string MembershipRuleProcessingState;
    
        /// <summary>
        /// Gets or sets on premises domain name.
        /// Contains the on-premises domain FQDN, also called dnsDomainName synchronized from the on-premises directory. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect.Returned by default. Read-only.
        /// </summary>
        public string OnPremisesDomainName;
    
        /// <summary>
        /// Gets or sets on premises last sync date time.
        /// Indicates the last time at which the group was synced with the on-premises directory.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Returned by default. Read-only. Supports $filter.
        /// </summary>
        public Date OnPremisesLastSyncDateTime;
    
        /// <summary>
        /// Gets or sets on premises net bios name.
        /// Contains the on-premises netBios name synchronized from the on-premises directory. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect.Returned by default. Read-only.
        /// </summary>
        public string OnPremisesNetBiosName;
    
        /// <summary>
        /// Gets or sets on premises provisioning errors.
        /// Errors when using Microsoft synchronization product during provisioning. Returned by default.
        /// </summary>
        public IEnumerable<OnPremisesProvisioningError> OnPremisesProvisioningErrors;
    
        /// <summary>
        /// Gets or sets on premises sam account name.
        /// Contains the on-premises SAM account name synchronized from the on-premises directory. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect.Returned by default. Read-only.
        /// </summary>
        public string OnPremisesSamAccountName;
    
        /// <summary>
        /// Gets or sets on premises security identifier.
        /// Contains the on-premises security identifier (SID) for the group that was synchronized from on-premises to the cloud. Returned by default. Read-only.
        /// </summary>
        public string OnPremisesSecurityIdentifier;
    
        /// <summary>
        /// Gets or sets on premises sync enabled.
        /// true if this group is synced from an on-premises directory; false if this group was originally synced from an on-premises directory but is no longer synced; null if this object has never been synced from an on-premises directory (default). Returned by default. Read-only. Supports $filter.
        /// </summary>
        public bool? OnPremisesSyncEnabled;
    
        /// <summary>
        /// Gets or sets preferred data location.
        /// The preferred data location for the group. For more information, see  OneDrive Online Multi-Geo. Returned by default.
        /// </summary>
        public string PreferredDataLocation;
    
        /// <summary>
        /// Gets or sets preferred language.
        /// The preferred language for an Microsoft 365 group. Should follow ISO 639-1 Code; for example 'en-US'. Returned by default.
        /// </summary>
        public string PreferredLanguage;
    
        /// <summary>
        /// Gets or sets proxy addresses.
        /// Email addresses for the group that direct to the same group mailbox. For example: ['SMTP: bob@contoso.com', 'smtp: bob@sales.contoso.com']. The any operator is required to filter expressions on multi-valued properties. Returned by default. Read-only. Not nullable. Supports $filter.
        /// </summary>
        public IEnumerable<string> ProxyAddresses;
    
        /// <summary>
        /// Gets or sets renewed date time.
        /// Timestamp of when the group was last renewed. This cannot be modified directly and is only updated via the renew service action. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Returned by default. Read-only.
        /// </summary>
        public Date RenewedDateTime;
    
        /// <summary>
        /// Gets or sets security enabled.
        /// Specifies whether the group is a security group. Returned by default. Supports $filter.
        /// </summary>
        public bool? SecurityEnabled;
    
        /// <summary>
        /// Gets or sets security identifier.
        /// Security identifier of the group, used in Windows scenarios. Returned by default.
        /// </summary>
        public string SecurityIdentifier;
    
        /// <summary>
        /// Gets or sets theme.
        /// Specifies an Microsoft 365 group's color theme. Possible values are Teal, Purple, Green, Blue, Pink, Orange or Red. Returned by default.
        /// </summary>
        public string Theme;
    
        /// <summary>
        /// Gets or sets visibility.
        /// Specifies the visibility of a Microsoft 365 group. Possible values are: Private, Public, or Hiddenmembership; blank values are treated as public.  See group visibility options to learn more.Visibility can be set only when a group is created; it is not editable.Visibility is supported only for unified groups; it is not supported for security groups. Returned by default.
        /// </summary>
        public string Visibility;
    
        /// <summary>
        /// Gets or sets allow external senders.
        /// Indicates if people external to the organization can send messages to the group. Default value is false. Returned only on $select.
        /// </summary>
        public bool? AllowExternalSenders;
    
        /// <summary>
        /// Gets or sets auto subscribe new members.
        /// Indicates if new members added to the group will be auto-subscribed to receive email notifications. You can set this property in a PATCH request for the group; do not set it in the initial POST request that creates the group. Default value is false. Returned only on $select.
        /// </summary>
        public bool? AutoSubscribeNewMembers;
    
        /// <summary>
        /// Gets or sets hide from address lists.
        /// True if the group is not displayed in certain parts of the Outlook UI: the Address Book, address lists for selecting message recipients, and the Browse Groups dialog for searching groups; otherwise, false. Default value is false. Returned only on $select.
        /// </summary>
        public bool? HideFromAddressLists;
    
        /// <summary>
        /// Gets or sets hide from outlook clients.
        /// True if the group is not displayed in Outlook clients, such as Outlook for Windows and Outlook on the web; otherwise, false. Default value is false. Returned only on $select.
        /// </summary>
        public bool? HideFromOutlookClients;
    
        /// <summary>
        /// Gets or sets is subscribed by mail.
        /// Indicates whether the signed-in user is subscribed to receive email conversations. Default value is true. Returned only on $select.
        /// </summary>
        public bool? IsSubscribedByMail;
    
        /// <summary>
        /// Gets or sets unseen count.
        /// Count of conversations that have received new posts since the signed-in user last visited the group. Returned only on $select.
        /// </summary>
        public int? UnseenCount;
    
        /// <summary>
        /// Gets or sets is archived.
        /// </summary>
        public bool? IsArchived;
    
        /// <summary>
        /// Gets or sets app role assignments.
        /// </summary>
        //public IGroupAppRoleAssignmentsCollectionPage AppRoleAssignments;
    
        /// <summary>
        /// Gets or sets created on behalf of.
        /// The user (or application) that created the group. NOTE: This is not set if the user is an administrator. Read-only.
        /// </summary>
        public DirectoryObject CreatedOnBehalfOf;
    
        /// <summary>
        /// Gets or sets member of.
        /// Groups that this group is a member of. HTTP Methods: GET (supported for all groups). Read-only. Nullable.
        /// </summary>
        //public IGroupMemberOfCollectionWithReferencesPage MemberOf;
    
        /// <summary>
        /// Gets or sets members.
        /// Users and groups that are members of this group. HTTP Methods: GET (supported for all groups), POST (supported for Microsoft 365 groups, security groups and mail-enabled security groups), DELETE (supported for Microsoft 365 groups and security groups) Nullable.
        /// </summary>
        //public IGroupMembersCollectionWithReferencesPage Members;
    
        /// <summary>
        /// Gets or sets members with license errors.
        /// A list of group members with license errors from this group-based license assignment. Read-only.
        /// </summary>
        // public IGroupMembersWithLicenseErrorsCollectionWithReferencesPage MembersWithLicenseErrors;
    
        /// <summary>
        /// Gets or sets owners.
        /// The owners of the group. The owners are a set of non-admin users who are allowed to modify this object. Limited to 100 owners. HTTP Methods: GET (supported for all groups), POST (supported for Microsoft 365 groups, security groups and mail-enabled security groups), DELETE (supported for Microsoft 365 groups and security groups). Nullable.
        /// </summary>
        // public IGroupOwnersCollectionWithReferencesPage Owners;
    
        /// <summary>
        /// Gets or sets settings.
        /// Read-only. Nullable.
        /// </summary>
        // public IGroupSettingsCollectionPage Settings;
    
        /// <summary>
        /// Gets or sets transitive member of.
        /// </summary>
        // public IGroupTransitiveMemberOfCollectionWithReferencesPage TransitiveMemberOf;
    
        /// <summary>
        /// Gets or sets transitive members.
        /// </summary>
        // public IGroupTransitiveMembersCollectionWithReferencesPage TransitiveMembers;
    
        /// <summary>
        /// Gets or sets accepted senders.
        /// The list of users or groups that are allowed to create post's or calendar events in this group. If this list is non-empty then only users or groups listed here are allowed to post.
        /// </summary>
        // public IGroupAcceptedSendersCollectionPage AcceptedSenders;
    
        /// <summary>
        /// Gets or sets calendar.
        /// The group's calendar. Read-only.
        /// </summary>
        // public Calendar Calendar;
    
        /// <summary>
        /// Gets or sets calendar view.
        /// The calendar view for the calendar. Read-only.
        /// </summary>
        // public IGroupCalendarViewCollectionPage CalendarView;
    
        /// <summary>
        /// Gets or sets conversations.
        /// The group's conversations.
        /// </summary>
        // public IGroupConversationsCollectionPage Conversations;
    
        /// <summary>
        /// Gets or sets events.
        /// The group's calendar events.
        /// </summary>
        // public IGroupEventsCollectionPage Events;
    
        /// <summary>
        /// Gets or sets photo.
        /// The group's profile photo
        /// </summary>
        // public ProfilePhoto Photo;
    
        /// <summary>
        /// Gets or sets photos.
        /// The profile photos owned by the group. Read-only. Nullable.
        /// </summary>
        // public IGroupPhotosCollectionPage Photos;
    
        /// <summary>
        /// Gets or sets rejected senders.
        /// The list of users or groups that are not allowed to create posts or calendar events in this group. Nullable
        /// </summary>
        // public IGroupRejectedSendersCollectionPage RejectedSenders;
    
        /// <summary>
        /// Gets or sets threads.
        /// The group's conversation threads. Nullable.
        /// </summary>
        // public IGroupThreadsCollectionPage Threads;
    
        /// <summary>
        /// Gets or sets drive.
        /// The group's default drive. Read-only.
        /// </summary>
        // public Drive Drive;
    
        /// <summary>
        /// Gets or sets drives.
        /// The group's drives. Read-only.
        /// </summary>
        // public IGroupDrivesCollectionPage Drives;
    
        /// <summary>
        /// Gets or sets sites.
        /// The list of SharePoint sites in this group. Access the default site with /sites/root.
        /// </summary>
        // public IGroupSitesCollectionPage Sites;
    
        /// <summary>
        /// Gets or sets extensions.
        /// The collection of open extensions defined for the group. Read-only. Nullable.
        /// </summary>
        // public IGroupExtensionsCollectionPage Extensions;
    
        /// <summary>
        /// Gets or sets group lifecycle policies.
        /// The collection of lifecycle policies for this group. Read-only. Nullable.
        /// </summary>
        // public IGroupGroupLifecyclePoliciesCollectionPage GroupLifecyclePolicies;
    
        /// <summary>
        /// Gets or sets planner.
        /// Entry-point to Planner resource that might exist for a Unified Group.
        /// </summary>
        // public PlannerGroup Planner;
    
        /// <summary>
        /// Gets or sets onenote.
        /// Read-only.
        /// </summary>
        // public Onenote Onenote;
    
        /// <summary>
        /// Gets or sets team.
        /// </summary>
        // public Team Team;
    
    }
}

