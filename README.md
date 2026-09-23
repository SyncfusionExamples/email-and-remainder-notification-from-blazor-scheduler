# Email and Reminder Notification from Blazor Scheduler

## Overview

This sample demonstrates how to configure email notifications and reminder notifications using the Syncfusion [Blazor Scheduler](https://www.syncfusion.com/scheduler-sdk/blazor-scheduler) component. The implementation integrates appointment scheduling with custom email delivery logic and reminder workflows so that users can be notified about upcoming events. The project includes dedicated email service classes, appointment models, configuration settings, and an HTML email template used to generate notification messages.

## Key Features

- Configures Scheduler-based event notification workflows.
- Uses custom email service implementations located in the `EmailServices` folder.
- Stores SMTP and email-related configuration in `appsettings.json`.
- Uses an `Email_Template.html` file as the notification email template.
- Demonstrates appointment-based notification processing.
- Supports sending email notifications for scheduled events.
- Supports reminder notifications for upcoming appointments.
- Uses Scheduler resources with email information configured in `Pages/Index.razor`.
- Includes appointment models stored in the `Models` folder.
- Demonstrates integration between Scheduler events and custom notification services.

## Prerequisites

- Visual Studio 2022 or Visual Studio Code
- .NET SDK compatible with the project's target framework

## How to Run the Project

**Visual Studio 2022**

1. Clone or download this repository.
2. Open the solution file:

   `EmailScheduler.sln`

3. Restore NuGet packages.
4. Ensure the startup project is:

   `EmailScheduler`

5. Configure valid email credentials in:

   `appsettings.json`

6. Configure resource email information in:

   `Pages/Index.razor`

7. Build the solution.
8. Run the application using `Ctrl+F5`.


**Visual Studio Code**

1. Open the repository folder in Visual Studio Code.
2. Open the integrated terminal.
3. Navigate to the directory containing `EmailScheduler.csproj`.

```bash
dotnet restore
dotnet run
```

4. Configure email credentials in `appsettings.json` and add resource email in `Pages/Index.razor` file before launching the application.


## Project Structure

`Pages/Index.razor` — Contains the primary Scheduler implementation, appointment configuration, resource setup, and notification workflow integration.

`Program.cs` — Registers services and configures application startup.

`EmailServices/IEmailService.cs` — Defines the notification service contract used by the application.

`EmailServices/EmailService.cs` — Implements email delivery functionality.

`EmailServices/EmailSettings.cs` — Defines SMTP and email configuration settings.

`Models/EventModel.cs` — Represents Scheduler appointment data used by notification workflows.

`Email_Template.html` — HTML template used for email notification content.

`appsettings.json` — Stores application and email configuration settings.

## Support and Feedback

- For general product questions, visit the [Syncfusion Community Forum](https://www.syncfusion.com/forums) or [Syncfusion Support](https://www.syncfusion.com/support).
- To report an issue specific to this sample, open a GitHub issue in this repository.
- Official Scheduler documentation: https://help.syncfusion.com/scheduler-sdk/blazor/schedule/getting-started
- **Blog**: [How to Send Emails and Reminders for Events in Blazor Scheduler](https://www.syncfusion.com/blogs/post/how-to-send-emails-and-reminders-for-events-in-blazor-scheduler.aspx)

## License

This is a Syncfusion sample project provided to demonstrate product usage. Review the [Syncfusion license terms](https://www.syncfusion.com/sales/pricing?category=ui-components) before using Syncfusion components in your own applications.

