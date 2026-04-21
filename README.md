# Email and Reminder Notification from Blazor Scheduler

## Overview

This sample demonstrates how to configure and implement email and reminder notifications within a Blazor Scheduler application. The project showcases the integration of notification features with the Syncfusion Blazor Scheduler component, allowing users to send automated emails and reminders for scheduled events.

## Features

- Send email notifications for scheduled events
- Configure reminder notifications for attendees
- Customize email templates and reminder settings
- Integration with Blazor Scheduler component
- Secure credential management for email configuration

## Prerequisites

* Visual Studio 2022
* .NET 6 or higher
* Syncfusion Blazor components package

## How to Run the Project

1. Checkout this project to a location in your disk.
2. Open the solution file using Visual Studio 2022.
3. Restore the NuGet packages by rebuilding the solution.
4. Configure email credentials in the `appsettings.json` file.
5. Add resource email in the `Pages/Index.razor` file.
6. Run the project.

## Configuration

Before running the application, ensure you have:

- **Email Credentials**: Configure your email provider credentials in `appsettings.json` file with appropriate authentication details.
- **Resource Email**: Add the resource email address in `Pages/Index.razor` file to specify notification recipients.
- **SMTP Settings**: Configure SMTP server details including host, port, and authentication parameters.

## Documentation

For comprehensive information about the Syncfusion Blazor Scheduler and documentation, refer to:

- [Blazor Scheduler Introduction](https://blazor.syncfusion.com/documentation/introduction)
- [Blazor Scheduler Getting Started](https://blazor.syncfusion.com/documentation/schedule/getting-started)

## Additional Resources

**Blog**: [How to Send Emails and Reminders for Events in Blazor Scheduler](https://www.syncfusion.com/blogs/post/how-to-send-emails-and-reminders-for-events-in-blazor-scheduler.aspx)

## Support

For support and additional resources, visit the Syncfusion documentation and community forums.
