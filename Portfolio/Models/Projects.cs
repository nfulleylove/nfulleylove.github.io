namespace Portfolio.Models;

internal static class Projects
{
    internal static IEnumerable<Project> AllProjects =>
        new List<Project>
    {
        new Project
        {
            Company = "Gratte Brothers",
            StartDate = new DateOnly(2018,1,1),
            EndDate = new DateOnly(2020,1,1),
            Description = $"<p>Password Management System is a secure and convenient web application that enables employees and contractors to store passwords and details for assets on external sites.<br><br>" +
            "Administrators can manage the sites, assets, login details, and provide a certain level of access for users.<br><br>" +
            "When at a site, given the relevant permissions, the user can view the login details for a specific asset.<br><br>" +
            "MFA is enforced, and sessions time out from inactivity to enhance security.</p>",
            Href = null,
            Name = "Password Management System",
            Technologies = new string[] { "C#", "MVC", "Bootstrap", "EF Core", "IdentityServer4" },
            IsFeatured = true
        },
        new Project
        {
            Company = "Gratte Brothers",
            StartDate = new DateOnly(2020,1,1),
            EndDate = new DateOnly(2022,1,1),
            Description = "<p>Site Diaries allows site managers to record daily activities and raise any site issues each day.<br><br>" +
            "With this application, users can easily create and maintain digital diaries, capturing essential information such as weather conditions, morale, site progress, and workforce attendance.<br><br>" +
            "The Site Diaries application also offers features like photo and document attachments, allowing users to add supporting evidence to their entries.<br><br>" +
            "Additionally, it provides customisable reporting options, enabling users to generate comprehensive reports for informed decision-making.<br><br>" +
            "It is available on web and mobile devices and was initially developed in Xamarin, authenticated via IdentityServer4, before being ported to MAUI and Azure.</p>",
            Href = null,
            Name = "Site Diaries",
            Technologies = new string[] { "C#", "Blazor", "MAUI", "EF Core", "Azure" },
            IsFeatured = true
        },
        new Project
        {
            Company = "Gratte Brothers",
            StartDate = new DateOnly(2021,1,1),
            Description = "<p>Health &amp; Safety Reporting is a comprehensive application, developed as part of a digitilisation initiative.<br><br>" +
            "In an effort to reduce physical paperwork, the application replicates several Health &amp; Safety forms such as DSE, Risk Assessments, and Support Visits.<br><br>" +
            "It also includes a Wellbeing section that provides links and contact details for various support providers.<br><br>" +
            "This application is available on web and mobile devices</p>",
            Href = null,
            Name = "Health & Safety Reporting",
            Technologies = new string[] { "C#", "Blazor", "Xamarin", "EF Core", "Azure" },
            IsFeatured = true
        },
        new Project
        {
            Company = "Gratte Brothers",
            StartDate = new DateOnly(2023,1,1),
            Description = "<p>Asset Tracker is a web application used to store, manage details, and audit changes for the assets in an organisation.<br><br>" +
            "IT is able to view device and supplier information, and assign/unassign them to employees, notifying the users if necessary.</p>",
            Name = "Asset Tracker",
            Technologies = new string[] { "C#", "Blazor", "EF Core", "Azure" },
            IsFeatured = true
        },
        new Project
        {
            Company = "Personal",
            StartDate = new DateOnly(2022,1,1),
            Description = "<p>Invoicer is a mobile application designed to provide a user-friendly solution that simplifies invoice generation.<br><br>" +
            "Once initially configured, invoices can be generated and sent to clients with just a few taps.<br><br>" +
            "This application was built using Flutter for Android devices.</p>",
            Href = "https://github.com/nfulleylove/Invoicer",
            Name = "Invoicer",
            Technologies = new string[] { "Flutter", "SQLite" },
            IsFeatured = true
        },
    };
}
