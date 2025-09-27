# RJTMS - Crew Transportation Management System 
## Technical Documentation


![Version](https://img.shields.io/badge/version-1.0.1.3-blue)
![Platform](https://img.shields.io/badge/platform-Windows-lightgrey)
![Docs](https://img.shields.io/badge/docs-available-brightgreen)
![.NET](https://img.shields.io/badge/.NET-4.8.1-blue)

The RJTMS solution is a robust application designed to manage various aspects of crew transportation scheduling and management. It includes features for user management, permissions handling, roster management, and reporting. The solution is implemented using VB.NET and leverages a SQL Server database for data storage.

### Purpose

The primary purpose of the RJTMS solution is to streamline transportation management processes, improve operational efficiency, and provide robust reporting capabilities.

### Scope

This solution is strictly intended for internal use by authorized RJ personnel.

---
# Developer Setup & Prerequisites

Before working with the RJTMS solution, ensure you have the following prerequisites installed:

- **Visual Studio 2022** (or later)
- **.NET Framework 4.8.1**
- **Visual Studio Installer Projects extension** ([Download from Microsoft official website](https://marketplace.visualstudio.com/items?itemName=VisualStudioClient.MicrosoftVisualStudio2022InstallerProjects))
- **SQL Server** (for database access)

### Opening the Solution

1. **Open the Solution**
   - Open the solution file (`RJTMS.sln`) located in the src directory.
2. **Restore NuGet Packages**
   - Visual Studio will automatically restore all required NuGet packages on opening the solution.
3. **Database Setup**
   - Open the (`scheme.sql`) from the database directory in SQL Server Management Studio and run the script to create required tables for the app to run properly. 
   - Update connection string by editing the `remoteDB` value in the `TMScore` project application settings.
		> This will be the master connection string used by the application to connect to the SQL Server database.
    
   - You'll need to insert some records in the DB tables you just created *Before* you run the application for the first time.
		
		```sql
		USE [GPS]
		GO

		INSERT INTO [dbo].[Userr] ([ID],[Name],[per],[Office])
		VALUES ({your_user_principal}, 'Test User', 3, 1)
		GO

		INSERT INTO [dbo].[Permissions] (
		 [ID],[Roster],[GS],[CG],[BD],[Arrivals],[Arr],[Orders],[Note],[uploadRoster],
		 [Reports],[arabic],[GSSDate],[uploadArrival],[RFDate],[RPickupTime],[RFlight],
		 [RCID],[RBus],[RGPSNote],[RBrfTime],[RArrTime],[RDMnote],[Rlate],[RCF],[RRNum],
		 [Risinsert],[RRID],[RGPSOfficer],[RDM],[RTransOfficer],[RDAtee],[Area],[CMobile],
		 [gGSID],[gGSName],[gPhone],[gAddress],[gShiftText],[gGPSCallTime],[gSDate],[gSenc],
		 [gGPSNote],[gBuss],[gDriver],[gArea],[gGPSShift],[gGPSCaller],[gTransOfficer],
		 [gGSShID],[KMReport],[KMInsert],[KMReportType],[CreateRoster])
		VALUES (
		 {your_user_principal},
		 1,1,1,1,1,1,1,1,1,
		 1,1,1,1,1,1,1,1,1,1,
		 1,1,1,1,1,1,1,1,1,1,
		 1,1,1,1,1,1,1,1,1,1,
		 1,1,1,1,1,1,1,1,1,1,
		 1,1,1)
		GO
		INSERT INTO [dbo].[ARRPer] (
		  [ID], [ArrID], [ADate], [ArrTime], [Flight],
		  [CID], [CEnName], [CArName], [CAddress],
		  [ShatelBus], [Bus], [Driver], [TransOfficerNote],
		  [Area], [CF], [RNum], [TransOfficer],
		  [Transofficer1], [isinserted], [DMNote]
		)
		VALUES (
		  {your_user_principal}, 1, 1, 1, 1,
		  1, 1, 1, 1,
		  1, 1, 1, 1,
		  1, 1, 1, 1,
		  1, 1, 1
		);
		GO
		```
		> **Note:** Replace `{your_user_principal}` with your actual user principal ID 'int' which is your RJ staff ID number.
 
		> This will create a user with full permissions to access all features of the application. The app will only run on a Windows machine that is logged in to your RJ account only.

4. **Installer Project**
   - To build the installer, ensure the Installer Projects extension is installed.
   - Build the `TMS` installer project to generate the MSI file.

> **Note:**
> All dependencies are managed via NuGet or are part of the .NET Framework. The installer project will include all necessary DLLs for deployment.

---

## Solution Architecture

### High-Level Architecture

The RJTMS solution follows a layered architecture:

- **Presentation Layer**: Windows Forms for user interaction.
- **Business Logic & Data Access Layer**: Encapsulates core functionalities such as user management, roster handling, and reporting. It handles database interactions using ADO.NET.

### Solution Structure

The solution consists of two projects:

- **TMScore**: Contains the following key components:
  - **Forms**: User interface elements for interacting with the application.
  - **Data Access**: Classes and methods for database operations.
  - **Utilities**: Helper functions and reusable components.
  - **Data Sets**: `.xsd` datasets for managing data.
- **TMS**: Contains the installer project `.vdproj` for the TMS application for Windows OS.
  - **Installer**: Setup project for deploying the application.

> The installer project is configured to include all necessary DLLs and dependencies required for the application to run smoothly on target machines.
> 
> **You will need to install the Visual Studio Installer Projects extension to open, build and manage the installer project.** [Download from Microsoft official website](https://marketplace.visualstudio.com/items?itemName=VisualStudioClient.MicrosoftVisualStudio2022InstallerProjects)

---

## Dependencies

> All dependencies of the RJTMS solution are limited to official Microsoft and System-provided NuGet packages, guaranteeing compatibility, reliability, and security.

- .NET Framework 4.8.1
- Azure.Core (v1.47.3)
- Azure.Identity (v1.15.0)
- Microsoft.Bcl.AsyncInterfaces (v9.0.0.8)
- Microsoft.Bcl.Cryptography (v9.0.0.8)
- Microsoft.Bcl.HashCode (v1.1.1)
- Microsoft.Bcl.TimeProvider (v9.0.0.8)
- Microsoft.Build.Framework (v17.14.8)
- Microsoft.Build.Tasks.Core (v17.14.8)
- Microsoft.Build.Utilities.Core (v17.14.8)
- Microsoft.CSharp
- Microsoft.Data.SqlClient (v6.1.1)
- Microsoft.Extensions.Caching.Abstractions (v9.0.0.8)
- Microsoft.Extensions.Caching.Memory (v9.0.0.8)
- Microsoft.Extensions.DependencyInjection.Abstractions (v9.0.0.8)
- Microsoft.Extensions.Logging.Abstractions (v9.0.0.8)
- Microsoft.Extensions.Options (v9.0.0.8)
- Microsoft.Extensions.Primitives (v9.0.0.8)
- Microsoft.Identity.Client (v4.76.0)
- Microsoft.Identity.Client.Extensions.Msal (v4.76.0)
- Microsoft.IdentityModel.Abstractions (v8.14.0)
- Microsoft.IdentityModel.JsonWebTokens (v8.14.0)
- Microsoft.IdentityModel.Logging (v8.14.0)
- Microsoft.IdentityModel.Protocols (v8.14.0)
- Microsoft.IdentityModel.Protocols.OpenIdConnect (v8.14.0)
- Microsoft.IdentityModel.Tokens (v8.14.0)
- Microsoft.IO.Redist (v6.1.0)
- Microsoft.NET.StringTools (v17.14.8)
- Microsoft.Office.Interop.Access (v15.0.4420.1018)
- Microsoft.Office.Interop.Excel (v15.0.4795.1001)
- Microsoft.Office.Interop.Outlook (v15.0.4797.1004)
- Microsoft.Web.WebView2.Core (v1.0.3405.78)
- Microsoft.Web.WebView2.WinForms (v1.0.3405.78)
- Microsoft.Web.WebView2.Wpf (v1.0.3405.78)
- Office (v11.0.0.0)
- System.Buffers (v4.6.1)
- System.ClientModel (v1.6.1)
- System.Collections.Immutable (v9.0.0.8)
- System.ComponentModel.DataAnnotations
- System.Configuration
- System.Configuration.ConfigurationManager (v9.0.0.8)
- System.Data
- System.Data.Common (v4.3.0)
- System.Deployment
- System.Diagnostics.DiagnosticSource (v9.0.0.8)
- System.Drawing
- System.Formats.Asn1 (v9.0.0.8)
- System.Formats.Nrbf (v9.0.0)
- System.IdentityModel
- System.IdentityModel.Tokens.Jwt (v8.14.0)
- System.IO
- System.IO.Compression
- System.IO.FileSystem.AccessControl (v5.0.0)
- System.IO.Pipelines (v9.0.0.8)
- System.Memory (v4.6.3)
- System.Memory.Data (v9.0.0.8)
- System.Net.Http
- System.Numerics
- System.Numerics.Vectors (v4.6.1)
- System.Reflection
- System.Reflection.Metadata (v9.0.0)
- System.Resources.Extensions (v9.0.0)
- System.Runtime
- System.Runtime.CompilerServices.Unsafe (v6.1.2)
- System.Runtime.InteropServices.RuntimeInformation (v4.3.0)
- System.Runtime.Serialization
- System.Security
- System.Security.AccessControl (v6.0.1)
- System.Security.Cryptography.Algorithms
- System.Security.Cryptography.Encoding
- System.Security.Cryptography.Pkcs (v9.0.8)
- System.Security.Cryptography.Primitives
- System.Security.Cryptography.ProtectedData (v9.0.8)
- System.Security.Cryptography.X509Certificates
- System.Security.Principal.Windows (v5.0.0)
- System.ServiceModel
- System.ServiceProcess
- System.Text.Encodings.Web (v9.0.0.8)
- System.Text.Json (v9.0.0.8)
- System.Threading.Tasks.Dataflow (v9.0.0)
- System.Threading.Tasks.Extensions (v4.6.3)
- System.Windows.Forms
- System.Xaml
- System.Xml
- System.Core
- System.Data.DataSetExtensions
- System.Xml.Linq (v3.5.0.0)

#### COM References

- **OLXLib**
  > Provides interoperability with local Microsoft Outlook app, enabling the application to automate and interact with local Outlook features such as sending an email. This reference is used in accordance with Microsoft's COM guidelines and is limited to official, supported interfaces to ensure security and compliance.

#### Bootstrapper Packages

- Microsoft.Net.Framework.4.8.1

All dependencies are managed via NuGet or are part of the .NET Framework.

---

## Key Components (TMScore project)

### Home Screen (`home.vb`)

The home screen is the main dashboard of the RJTMS application, providing users with centralized access to all major features and operational data. It is implemented as a Windows Forms interface with a tabbed layout, designed for efficient navigation and management of transportation activities.

#### Design & Layout

- **Tabbed Interface**: The home screen uses a multi-tab design, allowing users to switch between different functional areas.
- **Header Section**: Displays quick-access controls.
- **Notification Marquee**: A scrolling label or marquee is present for displaying notes from the notes tab.
- **Main Content Area**: Each tab presents a distinct set of controls, grids, and input fields tailored to its function.

#### Tabs & Their Contents

The home screen contains the following tabs:

1. **Roster Tab** (`rosterTab`): Displays crew roster data in a grid. Allows searching, filtering, and managing crew assignments, viewing flight details, and updating records.
2. **Ground Staff Tab** (`groundStaffTab`): Shows ground staff schedules and assignments. Provides search and reporting features for staff management, and options to view and update ground staff records.
3. **CGS Tab** (`cgsTab`): Presents crew ground staff information, with tree views, search, and detailed data panels for crew and staff management.
4. **Driver Link Tab** (`driverLinkTab`): Provides access to driver records, assignment history, leave status, and vehicle information. Users can search for drivers, view schedules, and manage driver-related data.
5. **Arrivals RJ Tab** (`arrivalsRjTab`): Displays real-time arrival flights from the official RJ website.
6. **Arrivals Tab** (`ArrivalsTab`) [Preview]: Shows general arrival records, with panels for viewing, searching, and managing arrival data.
7. **Notes Tab** (`notesTab`): Allows users to view, add, and manage operational notes. Features a calendar view for navigating notes by date, and supports creating, editing, and deleting notes.
8. **Orders Tab** (`ordersTab`) [Preview]: Manages transportation orders, including creation, update, and reporting of bus and driver assignments. Users can search orders, view details, insert new orders, update, and delete orders.
9. **Create Roster Tab** (`createRosterTab`): Provides tools for creating new rosters, including data entry using daily schedules as excel sheets and generates one sheet that is acceptable by the import function in the roster tab.
10. **KM Report Tab** (`kmRreportTab`): Shows reports for fleet usage and trip tracking. Includes many options to filter by and exports reports to Excel or CSV.
11. **Reports Tab** (`reportsTab`): Offers advanced reporting features, including filters for date, area, and keywords. Users can generate, view, and export various operational and management reports.

Each tab contains context-specific controls such as:

- Data grids for displaying tabular data.
- Search boxes, combo boxes, and action buttons for filtering, selection, and record management.
- Calendar controls for date-based navigation.
- Labels and status indicators for quick reference.
- Link labels for navigation and quick actions.

#### Usage Notes

- The home screen coordinates data loading, user permissions, and event handling for all major features.
- Inline comments within `home.vb` provide further details on the logic, event handling, and UI interactions for each tab and control.

---

### User Management

#### Classes

- **usersControl**: Manages user-related functionalities.

#### Methods

- `LoadAllUsers`: Loads all users from the `Userr` table.
- `CreatePermissionCheckboxes`: Dynamically creates checkboxes for permissions.
- `btnLoad_Click`: Handles user creation and updates.
- `delete_Click`: Deletes a user and their permissions.

---

### Roster Management

#### Classes

- **rosterSearch**: Handles roster searches.
- **rosterAddFlight**: Manages flight additions to rosters.

#### Methods

- `btnroster_Click`: Adds new roster entries.
- `rosterper`: Retrieves permissions for roster management.

---

### Notes Management

#### Classes

- **notes**: Manages notes.

#### Methods

- `GetNotesBetween`: Retrieves notes within a date range.
- `notesTab_Enter`: Loads notes when the notes tab is entered.

---

### Reporting

#### Classes

- **home**: Manages reporting functionalities.

#### Methods

- `ExportToCsv`: Exports data to CSV.
- `ExportToExcelInterop`: Exports data to Excel.
- `BuildSqlQuery`: Constructs SQL queries for reports.
- `btnroster_Click`: Adds new roster entries.
- `btnLoad_Click_1`: Loads data for reports and user management.
- `RefreshNotes`: Refreshes notes displayed on the dashboard.
- `Form1_Load`: Initializes the dashboard and loads initial data.

---

### Utilities

- `ErrorLog`: Logs errors.
- `ReleaseObject`: Releases COM objects.
- `TryParseAndFormatDate`: Parses and formats dates.

---

### Crew Search

#### Classes

- **crewSearch**: Provides crew member search and call-out functionality.

#### Methods

- `OK_Button_Click`: Confirms selection and closes the form.
- `Cancel_Button_Click`: Cancels and closes the form.
- `crewSearch_KeyDown`: Handles Enter/Escape for search/close.
- `crewSearch_Load`: Sets form owner to `home`.
- `TextBox3_DoubleClick`: Triggers search.
- `Button1_Click`: Initiates web dialer call and logs to `CallOutRoster`.
- `Button2_Click`: Closes the form.
- `TextBox3_MouseDoubleClick`: Triggers search.

---

### Add Flight to Roster

#### Classes

- **rosterAddFlight**: Manages adding new crew flight records to the roster.

#### Methods

- `OK_Button_Click`: Inserts new crew records into `FullRoster` based on grid values.
- `Cancel_Button_Click`: Cancels and closes the form.
- `rosterAddFlight_Load`: Initializes form and opens connection.
- `Da1_CellValueChanged`: Populates row details from the `mobile` table when a cell value changes.
- `Da1_CellContentClick`: Handles cell content clicks (no implementation).

---

### Notes Management (Note Details)

#### Classes

- **noteDetails**: Form for creating, editing, and deleting note records in the Notes table.

#### Methods

- `New(selectedDate As DateTime)`: Initializes form for creating a new note for a specific date.
- `New(noteId As Integer)`: Initializes form for editing an existing note by Id.
- `LoadNoteById`: Loads note data from the database and populates UI fields.
- `btnsave_Click`: Saves (inserts or updates) the note to the database.
- `btndelete_Click`: Deletes the note from the database (edit mode only).
- `OnFormClosed`: Cleans up event handlers when the form is closed.

---

### Roster Search

#### Classes

- **rosterSearch**: Provides search and navigation for crew roster records.

#### Methods

- `rosterSearch_KeyDown`: Handles key events for search/navigation.
- `rosterSearch_Load`: Initializes UI and language settings.
- `rosterSearch_VisibleChanged`: Focuses search input on visibility change.
- `TabControl1_SelectedIndexChanged`: Adjusts form size based on selected tab.
- `Button6_Click`: Performs search and populates results grid.
- `Button2_Click_1`: Closes the form.
- `Button1_Click_1`: Performs search based on tab and input.
- `Button3_Click_1`: Finds next matching record in the grid.
- `Button5_Click`: Closes the form.
- `TextBox1_KeyDown`: Triggers search on Enter key.
- `TextBox2_KeyDown`: Triggers search on Enter key.
- `D2_CellDoubleClick`: Updates GPSCallTime and highlights row.
- `Findee`: Finds and highlights a row in the grid.
- `D2_CellValueChanged`: Updates related grid when cell value changes.

---

### Insert New Arrival

#### Classes

- **insertNewArr**: Form for inserting new crew arrival records into the Arrival table.

#### Methods

- `Button1_Click`: Inserts a new crew record into the Arrival table if an ID is provided.
- `insertnew_Load`: Loads arrival data and sets label values on form load.

---

### About Dialog

#### Classes

- **AboutBox**: Displays application information and copyright details.

#### Methods

- `AboutBox_Load`: Sets form title and label values based on application info.
- `OKButton_Click`: Closes the AboutBox form.

---

### Wait Form

#### Classes

- **waitForm**: Displays a waiting/loading indicator during long-running operations.

---

### Web Dialer

#### Classes

- **webDialer**: Integrates with WebView2 to provide in-app web dialing functionality.

#### Methods

- `Webdialer_Load`: Initializes WebView2 and sets up event handlers on form load.
- `WebView2Ready`: Navigates to the specified URL when WebView2 is ready.
- `InitializeWebView`: Initializes and navigates the WebView2 control to a given URL.

---

### Edit Date

#### Classes

- **editDate**: Form for editing flight, briefing, date, and pickup time for crew records.

#### Methods

- `OK_Button_Click`: Updates flight, briefing, date, and pickup time for selected records.
- `Cancel_Button_Click`: Cancels and closes the form.
- `EditDate_Load`: Loads crew data for editing and sets up the form fields.

---

### Splash Screen

#### Classes

- **splashScreen**: Displays the application splash screen during startup.

#### Methods

- `New`: Initializes the splash screen and sets up scaling.
- `Form5_KeyDown`: Closes the splash screen if Escape is pressed.
- `Form5_Load`: Starts the timer and sets copyright label.
- `Timer1_Tick`: Shows the home form and hides the splash screen after a delay.

---

### Add Arrival Flight

#### Classes

- **arrAddFlight**: Manages adding new crew arrival records to the Arrival table.

#### Methods

- `Cancel_Button_Click`: Cancels and closes the form.
- `Da1_CellValueChanged`: Populates row details from the mobile table when a cell value changes.
- `arrAddFlight_FormClosed`: Closes the connection if open when the form is closed.
- `OK_Button_Click_1`: Inserts new crew records into Arrival based on grid values.

---

### Insert New Roster Entry

#### Classes

- **insertnew**: Form for inserting new crew records into the FullRoster table.

#### Methods

- `insertnew_Load`: Loads roster data and sets label values on form load.
- `TextBox1_KeyDown`: Adds a new row to the grid when Enter is pressed and a valid ID is entered.
- `Button1_Click_1`: Inserts a new crew record into FullRoster if an ID is provided.
- `Da1_MouseClick`: Sets TextBox1 text to the selected row's ID.

---

### Error Logging

#### Classes

- **errorlog**: Handles centralized error logging for the application.

---

## Database Schema

### Tables

Below is a summary of the current database schema as defined in the SQL file `database/scheme.sql`:

#### Arrival

- **ArrID** (int, PK, identity): Arrival record ID
- **ADate** (nvarchar(50)): Arrival date
- **ArrTime** (nvarchar(50)): Arrival time
- **Flight** (nvarchar(100)): Flight number
- **CID** (int): Crew ID
- **CEnName** (nvarchar(50)): Crew English name
- **CArName** (nvarchar(50)): Crew Arabic name
- **CAddress** (nvarchar(50)): Crew address
- **ShatelBus** (nvarchar(50)): Shatel bus info
- **Bus** (nvarchar(20)): Bus info
- **Driver** (nvarchar(20)): Driver name
- **TransOfficerNote** (nvarchar(max)): Transportation officer note
- **Area** (int): Area
- **CF** (int, NOT NULL): Crew flag
- **RNum** (int): Roster number
- **TransOfficer** (int): Transportation officer
- **Transofficer1** (int): Transportation officer 1
- **isinserted** (int): Inserted flag
- **DMNote** (nvarchar(max)): DM note

#### ARRPer

- **ID** (int, PK): Record ID
- **ArrID** (int): Arrival ID
- Other columns (all int): Reference to Arrival columns

#### BLine

- **lineID** (int, PK, identity): Line ID
- **LName** (nvarchar(50)): Line name
- **Shift** (char(10)): Shift

#### bus

- **tdid** (int, identity): Bus record ID
- **Bus** (nvarchar(20)): Bus number
- **drname** (nvarchar(20)): Driver name
- **Buss** (int): Bus ID
- **Driver** (nvarchar(20), NOT NULL): Driver name
- **areaa** (int): Area
- **REGEXPD** (datetime): Registration expiry date
- **xloc** (nchar(10)): X location
- **yloc** (nchar(10)): Y location

#### busloc

- **Longitude** (nchar(11)): Longitude
- **Latitude** (nchar(11)): Latitude
- **PlateNumber** (nchar(10)): Plate number

#### CallOutRoster

- **CallerID** (int): Caller ID
- **CalledID** (int): Called ID
- **CallTime** (nvarchar(70): Call time
- **CalledName** (nvarchar(50)): Called name
- **Mobile** (nvarchar(20)): Mobile number

#### CInOrder

- **COrderID** (int, PK, identity): Order record ID
- **OrderID** (int, FK): Order ID
- **CID** (int): Crew ID
- **ArName** (nvarchar(50): Arabic name
- **HomeAddress** (nvarchar(50)): Home address
- **Destination** (nvarchar(50)): Destination
- **PickupTime** (nvarchar(50)): Pickup time
- **Status** (nvarchar(50)): Status
- **ID** (int): ID

#### coordinates

- **ID** (int): Record ID
- **PLATE NUMBER** (nchar(50)): Plate number
- **LONGITUDE** (nchar(50)): Longitude
- **LATITUDE** (nchar(50)): Latitude
- **DATET TIME** (datetime): Date/time

#### CREW CANCELATION

- **ID** (int): Record ID
- **NAME** (nchar(30)): Name
- **FLIGHT** (nchar(10)): Flight
- **FLIGHT DATE** (nchar(10)): Flight date
- **CANCELATION NOTE** (nchar(10)): Cancelation note
- **CANCELATION DATE** (datetime): Cancelation date

#### DMLine

- **ID** (int, PK, identity): Line record ID
- **LDate** (varchar(50)): Line date
- **LShift** (char(1)): Line shift
- **ArrTime** (varchar(50)): Arrival time
- **LineName** (nvarchar(50), NOT NULL): Line name
- **LineNote** (nvarchar(max)): Line note
- **Nuser** (nvarchar(50)): User

#### DMNote

- **NoteID** (int, PK, identity): Note ID
- **NoteText** (text): Note text
- **NoteDtae** (varchar(50)): Note date

#### Driver

- **ID** (int, PK, identity): Driver ID
- **Driver** (nvarchar(max)): Driver name
- **section** (nvarchar(50)): Section
- **sick** (int): Sick leave
- **anual** (int): Annual leave
- **leave** (int): Leave

#### DTNote

- **NID** (int, PK, identity): Note ID
- **DriverID** (int): Driver ID
- **DName** (nvarchar(50)): Driver name
- **DSCT** (nvarchar(20)): Section
- **DVNum** (nvarchar(20)): Vehicle number
- **DSickL** (int): Sick leave
- **DBAnn** (int): Annual leave
- **DLH** (varchar(20)): Leave hours
- **DMNote** (nvarchar(max)): DM note
- **DMID** (int): DM ID
- **NDate** (varchar(50)): Note date

#### Email

- **ID** (int, PK, identity): Email ID
- **Email** (nvarchar(50)): Email address
- **Date** (nvarchar(50)): Date
- **busnum** (nvarchar(max)): Bus number

#### Employee

- **EMPLOYEE_NUMBER** (int, PK): Employee number
- **EMPLOYEE_NAME** (nvarchar(50)): Employee name
- **ARABIC NAME** (nvarchar(50)): Arabic name
- **DEPARTMENT** (nvarchar(50)): Department
- **USING_RJ_BUS** (nvarchar(5)): Using RJ bus
- **LOCATION** (nvarchar(50)): Location

#### engdata

- **id** (int, PK): Engineer ID
- **name** (nvarchar(50)): Name
- **addd** (nvarchar(max)): Address
- **mobile** (nvarchar(20)): Mobile
- **Area** (int): Area

#### Engineer

- **Engineer** (int, PK): Engineer ID
- **EMPLOYEE_NAME** (nvarchar(50)): Name
- **ARABIC NAME** (nvarchar(50)): Arabic name
- **DEPARTMENT** (nvarchar(50)): Department
- **USING_RJ_BUS** (nvarchar(5)): Using RJ bus
- **LOCATION** (nvarchar(50)): Location
- **DATE** (date): Date
- **BUS_LINE** (nchar(20)): Bus line

#### engineers

- **ID** (int): Engineer ID
- **name** (nvarchar(50)): Name
- **Address** (nvarchar(max)): Address
- **Phone** (nvarchar(10)): Phone
- **ShiftText** (nvarchar(10)): Shift text
- **GPSCallTime** (nvarchar(50)): GPS call time
- **SDate** (Date): Shift date
- **GPSNote** (nvarchar(max)): GPS note
- **Buss** (nvarchar(50)): Bus
- **Driver** (nvarchar(50)): Driver
- **Area** (int): Area
- **GPSCaller** (int): GPS caller
- **ENGhID** (int, NOT NULL): Engineer header ID

#### engtimp

- **ID** (int, PK): Engineer ID
- **name** (nvarchar(50)): Name
- **Address** (nvarchar(max)): Address
- **Phone** (nvarchar(50)): Phone
- **Shifttime** (nvarchar(50)): Shift time
- **shiftdate** (datetime): Shift date

#### errorlog

- **LogID** (int, PK, identity): Log ID
- **LogDateTime** (nvarchar(100)): Log date/time
- **UserID** (int): User ID
- **errorText** (nvarchar(max)): Error text

#### event

- **id** (int, PK, identity): Event ID
- **y** (int): Year
- **m** (int): Month
- **d** (int): Day
- **MyEvent** (nvarchar(max), NOT NULL): Event description
- **Important** (nchar(10), NOT NULL): Important flag

#### FullRoster

- **RID** (int, PK, identity): Roster ID
- **FDate** (nvarchar(50)): Flight date
- **PickupTime** (nvarchar(50): Pickup time
- **Flight** (nvarchar(max)): Flight
- **CID** (int): Crew ID
- **CEnName** (nvarchar(50)): Crew English name
- **CMobile** (nvarchar(50)): Crew mobile
- **CArName** (nvarchar(50)): Crew Arabic name
- **CAdd** (nvarchar(50)): Crew address
- **GPSCallTime** (nvarchar(max)): GPS call time
- **Bus** (nvarchar(50)): Bus
- **Driver** (nvarchar(50)): Driver
- **GPSNote** (nvarchar(max)): GPS note
- **Area** (int): Area
- **BrfTime** (nvarchar(50)): Briefing time
- **ArrTime** (nvarchar(50)): Arrival time
- **DMnote** (nvarchar(max)): DM note
- **late** (nvarchar(50)): Late flag
- **CF** (int): Crew flag
- **RNum** (int): Roster number
- **isinsert** (int): Insert flag
- **GPSOfficer** (int): GPS officer
- **DM** (int): DM
- **TransOfficer** (int): Transportation officer
- **DAtee** (datetime): Date

#### gsmodby

- **GSSID** (int): GS ID
- **name** (nchar(50)): Name
- **BY** (int): By
- **date** (nchar(50)): Date
- **gsshift** (nchar(50)): GS shift

#### Gss

- **id** (int): GS ID
- **Name** (nvarchar(50)): Name
- **Phone** (nvarchar(20)): Phone
- **addd** (nvarchar(max)): Address
- **Area** (int): Area

#### GSShift

- **GSShID** (int, PK, identity): GS shift ID
- **GSID** (int): GS ID
- **GSName** (nvarchar(50)): GS name
- **Phone** (nvarchar(50)): Phone
- **Address** (nvarchar(50)): Address
- **ShiftText** (nvarchar(50)): Shift text
- **GPSCallTime** (nvarchar(max)): GPS call time
- **SDate** (nvarchar(100)): Shift date
- **Senc** (int): Senc
- **GPSNote** (nvarchar(max)): GPS note
- **Buss** (nvarchar(50)): Bus
- **Driver** (nvarchar(50)): Driver
- **Area** (int): Area
- **GPSShift** (int): GPS shift
- **GPSCaller** (int): GPS caller
- **TransOfficer** (int): Transportation officer

#### hh

- **gg** (datetime): Date/time

#### loader

- **LoadDateTime** (nvarchar(100)): Load date/time
- **LoaderID** (int): Loader ID
- **FileName** (nvarchar(100)): File name

#### Locator

- **ID** (int, PK): Locator ID
- **busnum** (nchar(10)): Bus number
- **locator** (nchar(500)): Locator

#### MaintenanceCase

- **ID** (int, PK, identity): Case ID
- **casetext** (nvarchar(200)): Case text

#### maintinance

- **ID** (int, PK, identity): Maintenance ID
- **Bus** (nvarchar(50)): Bus
- **InDate** (nvarchar(50)): In date
- **outDate** (nvarchar(50)): Out date
- **Problem** (nvarchar(max)): Problem
- **Status** (int): Status
- **EXPOutDate** (nvarchar(50)): Expected out date
- **Note** (nvarchar(max)): Note

#### MNote

- **ID** (int, PK, identity): Note ID
- **BusNum** (nvarchar(50)): Bus number
- **NNote** (nvarchar(max)): Note
- **Ndate** (nvarchar(50)): Note date
- **Nuser** (nvarchar(50)): User

#### mobile

- **id** (int): Mobile ID
- **Name** (nvarchar(50)): Name
- **areaa** (int): Area
- **Phone** (nvarchar(20)): Phone
- **HomeAddress** (nvarchar(max)): Home address
- **note** (nvarchar(max)): Note
- **GPSNote** (nvarchar(max)): GPS note
- **xloc** (nchar(20)): X location
- **yloc** (nchar(20)): Y location

#### Office

- **IDD** (int, PK): Office ID
- **Name** (nvarchar(20)): Name
- **Phone** (int): Phone

#### Orders

- **OrderID** (int, PK, identity): Order ID
- **CreatorID** (int): Creator ID
- **ODate** (nvarchar(50)): Order date
- **DriverName** (nvarchar(50)): Driver name
- **Bus** (nvarchar(30)): Bus
- **StartTime** (nvarchar(20)): Start time
- **EndTime** (nvarchar(20)): End time
- **StartKM** (int): Start KM
- **EndKM** (int): End KM
- **OrderStatus** (int): Order status
- **DepShatelBus** (nvarchar(20)): Departure Shatel bus
- **ArrShatelBus** (nvarchar(20)): Arrival Shatel bus

#### pathh

- **id** (int): Path ID
- **pathh** (nvarchar(max)): Path

#### Permissions

- **ID** (int, PK): User ID
- Multiple columns (int): Various permissions

#### Roster

- **ID** (int): Roster ID
- **ttime** (nvarchar(max)): Time
- **Bus** (nvarchar(20)): Bus
- **Driver** (nvarchar(50)): Driver
- **nnote** (nvarchar(max)): Note
- **ArTime** (nvarchar(50): Arrival time
- **DMnote** (nvarchar(max)): DM note
- **larr** (nvarchar(50)): Last arrival

#### sickleave

- **ID** (int, PK, identity): Sick leave ID
- **EID** (int, NOT NULL): Employee ID
- **NAME** (nchar(100), NOT NULL): Name
- **LEAVEXT** (nchar(1000)): Leave text
- **FROM** (date): From date
- **TO** (date): To date
- **IMG** (image): Image

#### sms

- **IDD** (int, PK, identity): SMS ID
- **Number** (nvarchar(20)): Number
- **smstext** (nvarchar(170)): SMS text
- **dt** (nvarchar(20)): Date/time

#### Userr

- **ID** (int, PK): User ID
- **Name** (nvarchar(100)): Name
- **ttime** (nvarchar(20): Time
- **per** (int): Permission level
- **Password** (nvarchar(50)): Password
- **Office** (int): Office

---

### Relationships & Constraints

- Many tables use identity columns for primary keys.
- Several tables have composite or single-column primary keys.
- Some tables use text/image columns for notes and logs.
- User and permissions management is handled via `Userr` and `Permissions` tables.

---

### File Objects

#### Rules

- **DateOnlyRule**: Ensures a datetime value is a date only (no time component).

#### User-Defined Data Types

- **Date**: User-defined type based on `datetime` (nullable).

#### Indexes

- **IX_Arrival**: Nonclustered index on `Arrival(ADate)`
- **PIndex (Engineer)**: Nonclustered index on `Engineer(Engineer)`
- **IX_FullRoster**: Nonclustered index on `FullRoster(FDate)`
- **PIndex (FullRoster)**: Nonclustered index on `FullRoster(FDate)`

---

## Deployment

### Prerequisites

- .NET Framework 4.8.1 installed on the target machine.
- SQL Server database set up and accessible internally.
- Required DLLs included in the deployment package [Automatically managed by the installer].

### Deployment Steps

1. **Build the Solution in Release Mode**
   - In Visual Studio, set the solution configuration to `Release`.
   - Right-click the `TMScore` project and select **Build**.
2. **Build the Installer Project to Generate the MSI**
   - Right-click the `TMS` installer project (`.vdproj`).
   - Select **Build**.
   - The MSI installer file will be generated in the `TMS\bin\Release` directory.
3. **Locate the MSI Installer**
   - Navigate to the output folder (`TMS\bin\Release`).
   - Find the generated `.msi` file (e.g., `TMS.msi`).
4. **Deploy the MSI Installer**
   - Copy the MSI file to the target machine(s).
   - Run the MSI installer to install the application and all required dependencies.

> **Note:**
> Ensure the target machine has .NET Framework 4.8.1 installed. All required DLLs and dependencies are included automatically by the installer project.

---

## Troubleshooting

### Logs

- Application centralized logs are stored in the `errorlog` db table.

---

## Security

### Application Security

- This app does not rely on *(username/password)* authentication, instead it uses Windows System Public APIs to get the current logged in user and matches it with the users table in the database to get the user permissions, if no match is found the app will show a message stating `YOU ARE NOT AUTHORIZED TO ACCESS THE SYSTEM`, then it will close.
- Using parameterized queries to prevent SQL injection.
- Encrypting sensitive data in the database.
- Implemented role-based access control (RBAC).
- Supports TLS 1.2, 1.3 for secure data transmission.
- Designed to work within a secure internal network.

---

## Appendices

### References

- [Microsoft Documentation](https://docs.microsoft.com/)
- [VB.NET](https://learn.microsoft.com/en-us/dotnet/visual-basic/)

---

This documentation provides a reference for the RJTMS solution. For further details, refer to the source code and inline comments.
